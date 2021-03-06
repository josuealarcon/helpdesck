CREATE PROCEDURE [dbo].[V4MVC_WORKERSLOCAL_SELECT_ICERTRESUMEN_INFORMES_CTTA]
(
   @EMPRESA						NVARCHAR(10)
  ,@DIVISION					NVARCHAR(4)
  ,@SUMA_FUNCIONARIOS_CTTA		INT OUTPUT
  ,@SUMA_CERTIFICADOS_CTTA		INT OUTPUT
  ,@SUMA_NOCERTIFICADOS_CTTA	INT OUTPUT
  ,@SUMA_HISTORICO_CTTA			INT OUTPUT
  ,@SUMA_FUNCIONARIOS_MDTE		INT OUTPUT
  ,@SUMA_CERTIFICADOS_MDTE		INT OUTPUT
  ,@SUMA_NOCERTIFICADOS_MDTE	INT OUTPUT
  ,@SUMA_HISTORICO_MDTE			INT OUTPUT
) AS
BEGIN

	DECLARE @M_EMPRESA		NVARCHAR(10)
	DECLARE @M_ACRONIMO		NVARCHAR(50)
	DECLARE @M_MANDANTE		INT
	DECLARE @M_CONTEO_SI	INT
	DECLARE @M_CONTEO_NO	INT
	DECLARE @M_CONTEO_BL	INT


	CREATE TABLE #RESULTADOS (
		EMPRESA					NVARCHAR(12)	COLLATE DATABASE_DEFAULT NOT NULL, 
		ACRONIMO				NVARCHAR(50)	COLLATE DATABASE_DEFAULT NOT NULL, 
		MANDANTE				INT,
		CUENTA_FUNCIONARIOS		INT,
		CUENTA_CERTIFICADOS		INT,
		CUENTA_NOCERTIFICADOS	INT,
		CUENTA_HISTORICO		INT
	)
	
	DECLARE CursorResultados CURSOR
		FOR
	SELECT
		*
	FROM 
		(
			SELECT
				RUT,
				EMPRESA,
				ACRONIMO,
				VALIDADO,
				(
					SELECT
						COUNT(MANDANTE)
					FROM A027_MANDANTES
					WHERE 
						MANDANTE = EMPRESA AND
						MANDANTE <> '108'
				) AS MANDANTE
			FROM VW_WL_ACREDITADO
			WHERE
				DIVISION = @DIVISION AND
				EMPRESA = @EMPRESA
			UNION
			SELECT
				RUT,
				EMPRESA,
				ACRONIMO,
				VALIDADO,
				(
					SELECT
						COUNT(MANDANTE)
					FROM A027_MANDANTES
					WHERE
						MANDANTE = EMPRESA AND
						MANDANTE <> '108'
				) AS MANDANTE
			FROM VW_WL_NOMINA
			WHERE 
				DIVISION = @DIVISION AND
				EMPRESA = @EMPRESA
			UNION
			SELECT
				RUT,
				EMPRESA,
				ACRONIMO,
				'BL',
				(
					SELECT
						COUNT(MANDANTE)
					FROM A027_MANDANTES
					WHERE
						MANDANTE = EMPRESA AND
						MANDANTE <> '108'
				) AS MANDANTE
			FROM VW_WL_BLOQ
			WHERE
				DIVISION = @DIVISION AND
				EMPRESA = @EMPRESA
		) PVT
	PIVOT (
		COUNT(RUT)
		FOR [VALIDADO] IN ([SI],[NO],[BL]) 
	) AS P 
	ORDER BY ACRONIMO

	OPEN CursorResultados

	FETCH NEXT FROM CursorResultados INTO 
		@M_EMPRESA, 
		@M_ACRONIMO,
		@M_MANDANTE,
		@M_CONTEO_SI,
		@M_CONTEO_NO,
		@M_CONTEO_BL

	SET @SUMA_FUNCIONARIOS_CTTA = 0
	SET @SUMA_CERTIFICADOS_CTTA = 0
	SET @SUMA_NOCERTIFICADOS_CTTA = 0
	SET @SUMA_HISTORICO_CTTA = 0
	
	SET @SUMA_FUNCIONARIOS_MDTE = 0
	SET @SUMA_CERTIFICADOS_MDTE = 0
	SET @SUMA_NOCERTIFICADOS_MDTE = 0
	SET @SUMA_HISTORICO_MDTE = 0

	WHILE @@FETCH_STATUS = 0
		BEGIN

			INSERT INTO #RESULTADOS
					(
						EMPRESA,
						ACRONIMO,
						MANDANTE,
						CUENTA_FUNCIONARIOS,
						CUENTA_CERTIFICADOS,
						CUENTA_NOCERTIFICADOS,
						CUENTA_HISTORICO
					)
			  VALUES(
						@M_EMPRESA, 
						@M_ACRONIMO,
						@M_MANDANTE,
						@M_CONTEO_SI + @M_CONTEO_NO,
						@M_CONTEO_SI,
						@M_CONTEO_NO,
						@M_CONTEO_BL
					)
			
			IF(@M_MANDANTE > 0)
				BEGIN
					SET @SUMA_FUNCIONARIOS_MDTE = @SUMA_FUNCIONARIOS_MDTE + @M_CONTEO_SI + @M_CONTEO_NO
					SET @SUMA_CERTIFICADOS_MDTE = @SUMA_CERTIFICADOS_MDTE + @M_CONTEO_SI
					SET @SUMA_NOCERTIFICADOS_MDTE = @SUMA_NOCERTIFICADOS_MDTE + @M_CONTEO_NO
					SET @SUMA_HISTORICO_MDTE = @SUMA_HISTORICO_MDTE + @M_CONTEO_BL
				END

			SET @SUMA_FUNCIONARIOS_CTTA = @SUMA_FUNCIONARIOS_CTTA + @M_CONTEO_SI + @M_CONTEO_NO
			SET @SUMA_CERTIFICADOS_CTTA = @SUMA_CERTIFICADOS_CTTA + @M_CONTEO_SI
			SET @SUMA_NOCERTIFICADOS_CTTA = @SUMA_NOCERTIFICADOS_CTTA + @M_CONTEO_NO
			SET @SUMA_HISTORICO_CTTA = @SUMA_HISTORICO_CTTA + @M_CONTEO_BL

			FETCH NEXT FROM CursorResultados INTO 
				@M_EMPRESA, 
				@M_ACRONIMO,
				@M_MANDANTE,
				@M_CONTEO_SI,
				@M_CONTEO_NO,
				@M_CONTEO_BL
		END

	CLOSE CursorResultados

	DEALLOCATE CursorResultados

	SELECT
		EMPRESA,
		ACRONIMO,
		MANDANTE,
		CUENTA_FUNCIONARIOS,
		CUENTA_CERTIFICADOS,
		CUENTA_NOCERTIFICADOS,
		CUENTA_HISTORICO
	FROM #RESULTADOS

END
