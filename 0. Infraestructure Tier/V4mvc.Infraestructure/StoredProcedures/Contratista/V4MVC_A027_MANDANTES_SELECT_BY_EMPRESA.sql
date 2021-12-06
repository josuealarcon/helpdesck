CREATE PROCEDURE [dbo].[V4MVC_A027_MANDANTES_SELECT_BY_EMPRESA]
(
 @EMPRESA	NVARCHAR(10) = NULL
)
AS
BEGIN

	SELECT MANDANTE		,OST		,ACTIVO 
	FROM A027_MANDANTES 
	WHERE MANDANTE = @EMPRESA

END
