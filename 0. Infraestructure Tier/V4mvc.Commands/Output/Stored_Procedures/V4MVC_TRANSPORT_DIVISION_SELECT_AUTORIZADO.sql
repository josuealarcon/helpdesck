CREATE PROCEDURE [dbo].[V4MVC_TRANSPORT_DIVISION_SELECT_AUTORIZADO]
(@DIVCOD	NVARCHAR(4) = NULL
,@PATENTE	NVARCHAR(6) = NULL) AS
BEGIN
	SELECT TD.PATENTE, TD.DIVISION, TD.AUTOR , D.PASES_VEHICULARES
	FROM TRANSPORT_DIVISION TD 
	INNER JOIN A024_DIVISIONES AS D ON D.DIVCOD = TD.DIVISION
	WHERE TD.PATENTE = @PATENTE AND TD.DIVISION = @DIVCOD AND TD.AUTOR <> 'BL' 
END

