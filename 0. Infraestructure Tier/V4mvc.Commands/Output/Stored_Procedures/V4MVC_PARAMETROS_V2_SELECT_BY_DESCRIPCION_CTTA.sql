CREATE PROCEDURE [dbo].[V4MVC_PARAMETROS_V2_SELECT_BY_DESCRIPCION_CTTA]
(
 @DESCRIPCION	NVARCHAR(50)
)
AS
BEGIN

	SELECT	ISNULL(Valor1,-1) AS Valor1
	FROM	PARAMETROS_V2
	WHERE	DESCRIPCION = @DESCRIPCION

END
