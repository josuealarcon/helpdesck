CREATE PROCEDURE [dbo].[V4MVC_PLANILLA_COTIZACION_SELECT_ONE_CONTROLLABORAL_CTTA]
(
  @ID_DOC		INT
 ,@IDEMPRESA	NVARCHAR(10)
 ,@PERIODO		NVARCHAR(6)
 ,@DIVISION		NVARCHAR(4)
 ,@OST			NVARCHAR(20)
) AS
BEGIN
	SELECT
		VALIDADO,
		STUFF(
				(
					SELECT ';' + TR.TIPO_RECHAZO
					FROM DOCS_CLABORAL_EMP_RECHAZO MR
					INNER JOIN DOCS_TIPO_RECHAZO TR
						ON MR.ID_TIPO_RECHAZO = TR.ID_TIPO_RECHAZO
					WHERE ID = PLANILLA_COTIZACION.ID FOR XML PATH ('')
				)
				, 1, 1, '') AS OBSERVACION,
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
							D.NOMBRE
						FROM DOCS D
						WHERE D.ID_DOC = @ID_DOC
					),''
				) AS NOM_DOC
	FROM PLANILLA_COTIZACION
	WHERE
		EMPRESA = @IDEMPRESA AND
		PERIODO = @PERIODO AND
		DIVISION = @DIVISION AND
		OST = @OST
END
