CREATE PROCEDURE [dbo].[V4MVC_DOCS_DEPENDENCIAS_VEHICULOSCTTA]
(@DIVCOD	NVARCHAR(4) = NULL
,@PATENTE	NVARCHAR(6) = NULL
,@ID_DOC	INT = NULL
,@IDEMPRESA NVARCHAR(11) = NULL) AS
BEGIN
	SELECT DP.ID_DOC_DEPEND, D.NOMBRE, D.COMUN,D.COMUN_DIV , '' AS VALIDADO
	INTO #TEMP
	FROM DOCS D 
	INNER JOIN DOCS_DEPEND DP ON DP.ID_DOC_DEPEND = D.ID_DOC
	WHERE DP.ID_DOC = @ID_DOC AND DP.ACTIVO = 'SI' AND DP.DIVISION = @DIVCOD

	DECLARE @ID_DOC_DEPEND	INT,
			@COMUN		    INT,
			@COMUN_DIV	NVARCHAR(2)

	DECLARE Docs_Dependencia CURSOR FOR
	SELECT ID_DOC_DEPEND , COMUN , COMUN_DIV FROM #TEMP 
	OPEN Docs_Dependencia

	FETCH Docs_Dependencia INTO    @ID_DOC_DEPEND , @COMUN , @COMUN_DIV

	WHILE (@@FETCH_STATUS = 0 )
		BEGIN
		DECLARE @VALIDADO NVARCHAR(2) = NULL
		IF @COMUN = 0 
			BEGIN
				IF @COMUN_DIV <> 'SI'
					BEGIN
						SELECT TOP 1 @VALIDADO = VALIDADO 
						FROM DOCS_TRANSPORT 
						WHERE (PATENTE = @PATENTE ) AND 
						(ID_DOC = @ID_DOC_DEPEND) AND 
						(EMPRESA = @IDEMPRESA) AND 
						((DIVISION = @DIVCOD ) OR (ISNULL(DIVISION, 'AA') = 'AA'))
						ORDER BY ID_DOCS_VEH DESC
					END
				ELSE
					BEGIN
						SELECT TOP 1 @VALIDADO = VALIDADO 
						FROM DOCS_TRANSPORT 
						WHERE (PATENTE = @PATENTE ) AND 
						(ID_DOC = @ID_DOC_DEPEND) AND 
						(EMPRESA = @IDEMPRESA)
						ORDER BY ID_DOCS_VEH DESC
					END
			END
		ELSE
			BEGIN
				IF @COMUN_DIV <> 'SI'
					BEGIN
						SELECT TOP 1 @VALIDADO = VALIDADO 
						FROM DOCS_TRANSPORT 
						WHERE (PATENTE = @PATENTE ) AND 
						(ID_DOC = @ID_DOC_DEPEND) AND 
						((DIVISION = @DIVCOD ) OR (ISNULL(DIVISION, 'AA') = 'AA'))
						ORDER BY ID_DOCS_VEH DESC
					END
			END

		IF @VALIDADO = 'SI' --OR @VALIDADO IS NULL
		BEGIN
			DELETE FROM #TEMP WHERE ID_DOC_DEPEND = @ID_DOC_DEPEND
		END

		FETCH Docs_Dependencia INTO @ID_DOC_DEPEND , @COMUN , @COMUN_DIV
		END
	CLOSE Docs_Dependencia
	DEALLOCATE Docs_Dependencia

	SELECT *  FROM #TEMP
END
