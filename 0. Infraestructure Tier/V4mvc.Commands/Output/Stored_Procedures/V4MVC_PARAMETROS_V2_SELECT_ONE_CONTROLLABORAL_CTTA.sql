CREATE PROCEDURE [dbo].[V4MVC_PARAMETROS_V2_SELECT_ONE_CONTROLLABORAL_CTTA]
(
  @Id_Parametro	INT
) AS
BEGIN
	SELECT
		TOP 1
		Valor1
	FROM PARAMETROS_V2
	WHERE Id_Parametro = @Id_Parametro
END
