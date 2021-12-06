CREATE PROCEDURE [dbo].[V4MVC_WORKERS_UPDATE_COVID_F300]
( @TIPODOC			  nvarchar(5) = NULL
, @RUT                nvarchar(10) = NULL
, @NOMBRES            nvarchar(50) = NULL
, @APELLIDOS          nvarchar(50) = NULL
 ) AS 
BEGIN

   UPDATE [WORKERS]
      SET [TIPODOC]			  = @TIPODOC
		, [NOMBRES]           = @NOMBRES
        , [APELLIDOS]         = @APELLIDOS
    WHERE [RUT]               = @RUT

END

