CREATE PROCEDURE [dbo].[V4MVC_ARCHIVOS_INSERT]
( @ID             uniqueidentifier = NULL OUTPUT
, @NOMBRE         nvarchar(255) = NULL
, @TIPOCONTENIDO  nvarchar(50) = NULL
, @FECHAMOD       nvarchar(8) = NULL
, @HORAMOD        nvarchar(8) = NULL
, @USUARIO        nvarchar(10) = NULL
, @ARCHIVO        image = NULL ) AS 
BEGIN

	SELECT @ID = NEWID() FROM SYSOBJECTS
	
   INSERT INTO [ARCHIVOS]
        ( ID      , NOMBRE  , TIPOCONTENIDO , FECHAMOD
        , HORAMOD , USUARIO , ARCHIVO       )
   VALUES
        ( @ID      , @NOMBRE  , @TIPOCONTENIDO , DBO.HOY(GETDATE())
        , DBO.AHORA(GETDATE()) , @USUARIO , @ARCHIVO       )

END


