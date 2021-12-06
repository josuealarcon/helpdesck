CREATE PROCEDURE [dbo].[V4MVC_POLIZA_MUERTE_SELECT_ONE_V3_CONTROLLABORAL_CTTA]
(
  @ID_DOC		INT
 ,@IDEMPRESA	NVARCHAR(10)
 ,@PERIODO		NVARCHAR(6)
) AS
BEGIN
	SELECT
		 PERIODO,
		 EMPRESA,
		 ID,
		 VALIDADO,
		 OBSERVACION,
		 COALESCE(
					(
						SELECT
							TOP 1
							E.ACRONIMO
						FROM ENTERPRISE E
						WHERE E.IDEMPRESA = @IDEMPRESA
					), ''
				) AS ACRO_EMPRESA,
		 [dbo].[V4MVC_FSTR_RUT](@IDEMPRESA) AS STRUT_EMPRESA,
		 COALESCE(
			(
				SELECT
					TOP 1
						DD.ID_DISPUTA
				FROM DOCS_DISPUTA_CLABORAL DD
				WHERE
					DD.EMPRESA = POLIZA_MUERTE.EMPRESA AND
					DD.PERIODO = POLIZA_MUERTE.PERIODO AND
					DD.ID_DOC = @ID_DOC AND
					DD.ID = POLIZA_MUERTE.ID
				ORDER BY DD.ID_DISPUTA DESC
			), -1
		 ) AS DISPUTA_ID,
		 IIF(EXISTS(
				SELECT * 
				FROM DOCS_DISPUTA_CLABORAL DD
				WHERE
					DD.EMPRESA = POLIZA_MUERTE.EMPRESA AND
					DD.PERIODO = POLIZA_MUERTE.PERIODO AND
					DD.ID_DOC = @ID_DOC AND
					DD.ID = POLIZA_MUERTE.ID
				ORDER BY DD.ID_DISPUTA DESC
				OFFSET 0 ROWS
		 ), 1 , 0) AS DISPUTA_EXISTE,
		 COALESCE(
			(
				SELECT
					TOP 1
					ARCHIVO
				FROM ARCHIVOS A
				WHERE A.ID = POLIZA_MUERTE.ID
			), NULL
		 ) AS ADJUNTO_CONTENIDO,
		 COALESCE(
			(
				SELECT
					TOP 1
					TIPOCONTENIDO
				FROM ARCHIVOS A
				WHERE A.ID = POLIZA_MUERTE.ID
			), NULL
		 ) AS ADJUNTO_TIPOCONTENIDO,
		 COALESCE(
			(
				SELECT
					TOP 1
					NOMBRE
				FROM ARCHIVOS A
				WHERE A.ID = POLIZA_MUERTE.ID
			), NULL
		 ) AS ADJUNTO_NOMBRE	
	FROM POLIZA_MUERTE
	WHERE
		EMPRESA = @IDEMPRESA AND
		PERIODO = @PERIODO
END
