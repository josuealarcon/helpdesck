CREATE PROCEDURE [dbo].[V4MVC_DOCS_WORKERS_INSERT_DOCUMENTO]
( @RUT              nvarchar(10) = NULL
, @ID_DOC           int = NULL
, @FECHA_MOD        nvarchar(8) = NULL
, @HORA_MOD         nvarchar(8) = NULL
, @USUARIO          nvarchar(10) = NULL
, @ID               uniqueidentifier = NULL
, @VALIDADO         nvarchar(2) = NULL
, @DIVISION         nvarchar(4) = NULL
, @EMPRESA          nvarchar(10) = NULL
, @FECHASUBE        nvarchar(8) = NULL
, @HORASUBE         nvarchar(8) = NULL ) AS 
BEGIN

   INSERT INTO [DOCS_WORKERS]
        ( RUT             , ID_DOC         , FECHA_MOD		, HORA_MOD        
		, USUARIO		  , ID             , VALIDADO       , DIVISION        
		, EMPRESA         , FECHASUBE      , HORASUBE    )
   VALUES
        ( @RUT            , @ID_DOC         , @FECHA_MOD	, @HORA_MOD        
		, @USUARIO		  , @ID             , @VALIDADO     , @DIVISION        
		, @EMPRESA        , @FECHASUBE      , @HORASUBE    )


END


