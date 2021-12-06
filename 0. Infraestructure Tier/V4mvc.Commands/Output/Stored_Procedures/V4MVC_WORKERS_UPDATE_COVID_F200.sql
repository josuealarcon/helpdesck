CREATE PROCEDURE [dbo].[V4MVC_WORKERS_UPDATE_COVID_F200]
( @TIPODOC			  nvarchar(5) = NULL
, @RUT                nvarchar(10) = NULL
, @NOMBRES            nvarchar(50) = NULL
, @APELLIDOS          nvarchar(50) = NULL
, @SEXO               nvarchar(10) = NULL
, @EMAIL              nvarchar(50) = NULL
, @OCUPACION              nvarchar(200) = NULL
, @TIPOSEGURO              nvarchar(50) = NULL
, @SEGURO              nvarchar(50) = NULL
 ) AS 
BEGIN

   UPDATE [WORKERS]
      SET [TIPODOC]			  = @TIPODOC
		, [NOMBRES]           = @NOMBRES
        , [APELLIDOS]         = @APELLIDOS
        , [SEXO]              = @SEXO
		, [EMAIL]             = @EMAIL
		, [OCUPACION]		  = @OCUPACION
		, [TIPOSEGURO]		  = @TIPOSEGURO
		, [SEGURO]			  = @SEGURO
    WHERE [RUT]               = @RUT

END

