CREATE PROCEDURE [dbo].[V4MVC_CERT_TASAS_SELECT_ONE_V2_CONTROLLABORAL_CTTA]
(
  @IDEMPRESA	NVARCHAR(10)
 ,@PERIODO		NVARCHAR(6)
) AS
BEGIN
	SELECT
		CERTUSUARIO,
		CERTFECHA,
		CERTHORA,
		VALIDADO
	FROM CERT_TASAS
	WHERE
		EMPRESA = @IDEMPRESA AND
		PERIODO = @PERIODO
END
