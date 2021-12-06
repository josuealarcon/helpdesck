CREATE PROCEDURE [dbo].[V4MVC_POLIZA_MUERTENATURAL_SELECT_ONE_CONTROLLABORAL_CTTA]
(
  @ID_DOC		INT
 ,@IDEMPRESA	NVARCHAR(10)
 ,@PERIODO		NVARCHAR(6)
) AS
BEGIN
	IF(@ID_DOC = -1)
		BEGIN
			SELECT
				TOP 1 
				@ID_DOC = CONVERT(INT, ISNULL(Valor1,-1))
			FROM parametros_v2
			WHERE
				Descripcion = 'Pago de Poliza Muerte Natural'
		END

	SELECT
		VALIDADO,
		(CASE WHEN OBSERVACION IS NULL THEN STUFF(
													(
													  SELECT
															';' + TR.TIPO_RECHAZO
													  FROM DOCS_CLABORAL_EMP_RECHAZO MR
													  INNER JOIN DOCS_TIPO_RECHAZO TR
														ON MR.ID_TIPO_RECHAZO = TR.ID_TIPO_RECHAZO
													  WHERE ID = POLIZA_MUERTENATURAL.ID FOR XML PATH ('')
													 ), 1, 1, '')
		 ELSE OBSERVACION END) AS OBSERVACION,
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
	FROM POLIZA_MUERTENATURAL
	WHERE
		EMPRESA = @IDEMPRESA AND
		PERIODO = @PERIODO
END
