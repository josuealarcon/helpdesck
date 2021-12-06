CREATE PROCEDURE [dbo].[V4MVC_DIRECCION_UPDATE_COVID_F300]
( @RUT        nvarchar(10) = NULL
, @DIRECCION  nvarchar(50) = NULL
, @COMUNA     nvarchar(50) = NULL
, @CIUDAD     nvarchar(50) = NULL
, @REGION     nvarchar(5) = NULL
, @CELULAR    nvarchar(50) = NULL
) AS 
BEGIN

   UPDATE [DIRECCION]
      SET [DIRECCION] = @DIRECCION
        , [COMUNA]    = @COMUNA
        , [CIUDAD]    = @CIUDAD
        , [REGION]    = @REGION
        , [CELULAR]   = @CELULAR
	WHERE RUT = @RUT


END

