CREATE PROCEDURE [dbo].[V4MVC_TRANSPORT_SELECT_ACREDITACIONVEHICULAR_CTTA]
(
  @EMPRESA		NVARCHAR(10) = NULL
 ,@DIVISION		NVARCHAR(10) = NULL
) AS
BEGIN

	CREATE TABLE #PATENTES (
	PATENTE		VARCHAR(8)		  COLLATE DATABASE_DEFAULT NOT NULL, 
	MARCA		NVARCHAR(50)	  COLLATE DATABASE_DEFAULT NOT NULL, 
	MODELO		NVARCHAR(50) 	  COLLATE DATABASE_DEFAULT NOT NULL
	);

	DECLARE @PATENTE NVARCHAR(8)  
	DECLARE @TIPO NVARCHAR(9)
	DECLARE @MARCA NVARCHAR(50)
	DECLARE @MODELO NVARCHAR(50)
	DECLARE @FECHA_ACTUAL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112)
	DECLARE @QUERY_INTERNO_EXISTE BIT
	DECLARE @QUERY_INTERNO_SEG_EXISTE BIT
	DECLARE @ID_DOC_FEC INT

	DECLARE PATENTE_CURSOR CURSOR  
	FOR
		SELECT
			PATENTE,
			CONVERT(NVARCHAR(9),TIPO) AS TIPO,
			MARCA,
			MODELO
		FROM TRANSPORT
		INNER JOIN TYPETRANS
			ON TIPO = IDTIPO
		WHERE
			EMPRESA = @EMPRESA
 
	OPEN PATENTE_CURSOR 
 
	FETCH NEXT FROM PATENTE_CURSOR INTO @PATENTE,@TIPO, @MARCA , @MODELO
 
	WHILE @@FETCH_STATUS = 0 
		BEGIN
		
		DECLARE @ID_DOC INT
		DECLARE @SUBEDOC NVARCHAR(2) 
		DECLARE @CONTINUAR BIT
		
		SET @CONTINUAR = 1

		DECLARE DOCS_CURSOR CURSOR  
		FOR
			SELECT
				D.ID_DOC,
				ISNULL(D.SUBEDOC,'NO') AS SUBEDOC 
			FROM DOCS D
			WHERE
				D.ID_TIPO_PROPIETARIO = 3 AND
				D.ACTIVO = 'SI' AND
				D.ID_DOC_OPCION = 1 AND
				D.ID_DOC IN
						(
						  SELECT
							DISTINCT ID_DOC
						  FROM DOCS_TIPOPASE
						  WHERE
							TIPOPASE = @TIPO AND
							(DIVISION IN(@DIVISION,'AA'))
						) AND
				D.ID_DOC <> '103'
 
		OPEN DOCS_CURSOR 
 
		FETCH NEXT FROM DOCS_CURSOR INTO @ID_DOC,@SUBEDOC
 
		WHILE (@@FETCH_STATUS = 0 AND @CONTINUAR = 1)
			BEGIN
				

				DECLARE @DOCVALIDADO NVARCHAR(2) = NULL
				SET @QUERY_INTERNO_EXISTE = 0
				SELECT
					TOP 1
					@QUERY_INTERNO_EXISTE = 1,
					@DOCVALIDADO = ISNULL(VALIDADO,'NO') 
				FROM DOCS_TRANSPORT DT 
				INNER JOIN DOCS D
					ON DT.ID_DOC = D.ID_DOC 
				WHERE
					(PATENTE = @PATENTE) AND 
					((DIVISION IN(@DIVISION)) OR (ISNULL(DIVISION, 'AA') = 'AA')) AND 
					(DT.ID_DOC = @ID_DOC) AND 
					(EMPRESA LIKE (CASE WHEN D.COMUN=1 THEN '%' ELSE @EMPRESA END))
				ORDER BY ID_DOCS_VEH DESC

				IF @QUERY_INTERNO_EXISTE = 1
					BEGIN		
						IF @DOCVALIDADO <> 'SI'
							BEGIN
								SET @CONTINUAR = 0
							END
					END
				ELSE
					BEGIN
						IF @SUBEDOC <> 'NO' 
						BEGIN
							SET @CONTINUAR = 0
						END
					END

				SET @QUERY_INTERNO_SEG_EXISTE = 0
				SELECT
					TOP 1
					@QUERY_INTERNO_SEG_EXISTE = 1,
					@ID_DOC_FEC = ID_DOC_FEC
				FROM DOCS_FEC DF
				WHERE
					ID_DOC_DEPEND = @ID_DOC AND
					ACTIVO = 'SI' AND
					VALIDO_MAYOR_HOY = 1
				
				IF @QUERY_INTERNO_SEG_EXISTE = 1
					BEGIN
						DECLARE @FECHA_DOC NVARCHAR(8) = NULL
						EXEC [V4MVC_DOCS_FEC_GETFECHAVEHLOCAL_NUEVALISTA_VEHICULOS_CTTA] @PATENTE = @PATENTE, @ID_DOC_FEC = @ID_DOC_FEC, @DIVCOD = @DIVISION, @IDEMPRESA = @EMPRESA, @FECHA_DOC = @FECHA_DOC OUTPUT
						
						IF @FECHA_DOC IS NULL
							BEGIN
								SET @FECHA_DOC = '19000101'
							END

						IF CONVERT(INT, @FECHA_ACTUAL) > CONVERT(INT, @FECHA_DOC)
							BEGIN
								SET @CONTINUAR = 0
							END
										
					END
					
				FETCH NEXT FROM DOCS_CURSOR INTO @ID_DOC,@SUBEDOC 
 
			END

		CLOSE DOCS_CURSOR  
		DEALLOCATE DOCS_CURSOR 

			--CURSOR 2

		IF @CONTINUAR = 1
			BEGIN
				INSERT INTO #PATENTES
				SELECT @PATENTE,@MARCA,@MODELO
			END

		FETCH NEXT FROM PATENTE_CURSOR INTO @PATENTE,@TIPO ,@MARCA,@MODELO
 
	END

	CLOSE PATENTE_CURSOR  
	DEALLOCATE PATENTE_CURSOR 

	SELECT * FROM #PATENTES

END

