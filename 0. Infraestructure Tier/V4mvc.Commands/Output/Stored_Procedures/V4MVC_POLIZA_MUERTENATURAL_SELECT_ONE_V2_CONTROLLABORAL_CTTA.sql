CREATE PROCEDURE [dbo].[V4MVC_POLIZA_MUERTENATURAL_SELECT_ONE_V2_CONTROLLABORAL_CTTA]
(
  @IDEMPRESA	NVARCHAR(10)
 ,@PERIODO		NVARCHAR(6)
) AS
BEGIN
	SELECT
		CERTUSUARIO,
		CERTFECHA,
		CERTHORA,
		VALIDADO,
		EMPRESA,
		PERIODO
	FROM POLIZA_MUERTENATURAL
	WHERE
		EMPRESA = @IDEMPRESA AND
		PERIODO = @PERIODO
END
