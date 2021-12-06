CREATE PROCEDURE [dbo].[V4MVC_WORKERS_INSERT_PERSONALES_CTTA]
( @RUT                nvarchar(10) = NULL
, @NOMBRES            nvarchar(50) = NULL
, @APELLIDOS          nvarchar(50) = NULL
, @FECHNACIM          nvarchar(8) = NULL
, @EMPRESA            nvarchar(10) = NULL
, @SEXO               nvarchar(10) = NULL
, @EMAIL              nvarchar(50) = NULL ) AS 
BEGIN

   INSERT INTO [WORKERS]
        ( RUT			  , NOMBRES           , APELLIDOS     , FECHNACIM      
		, EMPRESA         , SEXO			  , EMAIL          )
   VALUES
        ( @RUT			  , @NOMBRES          , @APELLIDOS    , @FECHNACIM      
		, @EMPRESA        , @SEXO			  , @EMAIL  )


END


