CREATE PROCEDURE [dbo].[V4MVC_A054_MOTIVOFINIQUITO_SELECT_ALL]
AS
BEGIN
	SELECT MF.MOTIVO , MF.GLOSA , MF.ACTIVO 
	FROM A054_MOTIVOFINIQUITO AS MF
	WHERE MF.ACTIVO = 'SI'
END
