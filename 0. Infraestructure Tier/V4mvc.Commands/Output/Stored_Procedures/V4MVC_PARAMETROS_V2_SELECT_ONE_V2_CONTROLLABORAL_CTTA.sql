CREATE PROCEDURE [dbo].[V4MVC_PARAMETROS_V2_SELECT_ONE_V2_CONTROLLABORAL_CTTA]
(
  @DESCRIPCION	NVARCHAR(50)
) AS
BEGIN
	SELECT
		TOP 1
		ISNULL(Valor1,-1) AS Valor1
	FROM parametros_v2
	WHERE
		Descripcion = @DESCRIPCION
END
