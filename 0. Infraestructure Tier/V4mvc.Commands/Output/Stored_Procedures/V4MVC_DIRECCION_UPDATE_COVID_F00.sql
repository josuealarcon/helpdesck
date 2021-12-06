CREATE PROCEDURE [dbo].[V4MVC_DIRECCION_UPDATE_COVID_F00]
( @RUT        nvarchar(10) = NULL
, @DIRECCION  nvarchar(50) = NULL
, @COMUNA     nvarchar(50) = NULL
, @CIUDAD     nvarchar(50) = NULL
, @REGION     nvarchar(5) = NULL
, @PAIS       nvarchar(50) = NULL
, @FONO       nvarchar(50) = NULL
, @CELULAR    nvarchar(50) = NULL
, @NOMCONTACTO nvarchar(100) = NULL
, @CELCONTACTO nvarchar(100) = NULL
) AS 
BEGIN

   UPDATE [DIRECCION]
      SET [DIRECCION] = @DIRECCION
        , [COMUNA]    = @COMUNA
        , [CIUDAD]    = @CIUDAD
        , [REGION]    = @REGION
        , [PAIS]      = @PAIS
        , [FONO]      = @FONO
        , [CELULAR]   = @CELULAR
		, [NOMCONTACTO] = @NOMCONTACTO
		, [CELCONTACTO] = @CELCONTACTO
	WHERE RUT = @RUT


END

