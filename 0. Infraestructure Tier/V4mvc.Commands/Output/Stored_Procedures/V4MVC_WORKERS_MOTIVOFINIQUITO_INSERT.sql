CREATE PROCEDURE [dbo].[V4MVC_WORKERS_MOTIVOFINIQUITO_INSERT]
( @RUT            nvarchar(10) = NULL
, @EMPRESA        nvarchar(10) = NULL
, @ID_DOC         int = NULL
, @IDARCHIVO      uniqueidentifier = NULL
, @MOTIVO         nvarchar(20) = NULL
, @USRREGISTRA    nvarchar(20) = NULL
, @FECHAREGISTRA  nvarchar(8) = NULL
, @HORAREGISTRA   nvarchar(8) = NULL
, @USRMOD         nvarchar(20) = NULL
, @FECHAMOD       nvarchar(8) = NULL
, @HORAMOD        nvarchar(8) = NULL ) AS 
BEGIN

   INSERT INTO [WORKERS_MOTIVOFINIQUITO]
        ( RUT    , EMPRESA     , ID_DOC        , IDARCHIVO   
        , MOTIVO , USRREGISTRA , FECHAREGISTRA , HORAREGISTRA
        , USRMOD , FECHAMOD    , HORAMOD       )
   VALUES
        ( @RUT    , @EMPRESA     , @ID_DOC				, @IDARCHIVO   
        , @MOTIVO , @USRREGISTRA , DBO.HOY(GETDATE())	, DBO.AHORA(GETDATE())
        , @USRMOD , DBO.HOY(GETDATE()) , DBO.AHORA(GETDATE()))

END


