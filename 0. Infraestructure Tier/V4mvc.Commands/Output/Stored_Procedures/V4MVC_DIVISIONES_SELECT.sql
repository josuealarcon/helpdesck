CREATE PROCEDURE [dbo].[V4MVC_DIVISIONES_SELECT]
(@DIVCOD           NVARCHAR(4) = NULL )AS
BEGIN

   SELECT DIVISION
		, DIVCOD
		, CTRL_CONDUCC 
		, PAIS
   FROM A024_DIVISIONES 
   WHERE (ACTIVO = N'SI') 
   AND DIVCOD = ISNULL(@DIVCOD,DIVCOD)
   ORDER BY DIVCOD

END

