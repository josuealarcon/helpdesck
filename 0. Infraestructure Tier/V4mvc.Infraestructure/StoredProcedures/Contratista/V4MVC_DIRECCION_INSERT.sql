CREATE PROCEDURE [dbo].[V4MVC_DIRECCION_INSERT]
( @RUT        nvarchar(10) = NULL
, @DIRECCION  nvarchar(50) = NULL
, @COMUNA     nvarchar(50) = NULL
, @CIUDAD     nvarchar(50) = NULL
, @REGION     nvarchar(5) = NULL
, @PAIS       nvarchar(50) = NULL
, @FONOHELP   nvarchar(50) = NULL
, @FONO       nvarchar(50) = NULL
, @CELULAR    nvarchar(50) = NULL
, @TIPO		  nvarchar(20) = NULL
, @NOMCONTACTO nvarchar(100) = NULL
, @CELCONTACTO nvarchar(100) = NULL) AS 
BEGIN

   INSERT INTO [DIRECCION]
        ( RUT     , DIRECCION , COMUNA  
        , CIUDAD  , REGION    , PAIS  , FONOHELP
        , FONO    , CELULAR   , TIPO  , NOMCONTACTO
		, CELCONTACTO)
   VALUES
        ( @RUT     , @DIRECCION  , @COMUNA  
        , @CIUDAD  , @REGION    , @PAIS  , @FONOHELP
        , @FONO    , @CELULAR	, @TIPO  , @NOMCONTACTO
		, @CELCONTACTO)

END

