CREATE PROCEDURE [dbo].[V4MVC_COMUNA_SELECT_BYCIUDAD]
(@CIUDAD NVARCHAR(50) = NULL)
AS
BEGIN
   SELECT DISTINCT COMUNA  FROM COMUNA  WHERE (CIUDAD = @CIUDAD)  ORDER BY COMUNA
END

