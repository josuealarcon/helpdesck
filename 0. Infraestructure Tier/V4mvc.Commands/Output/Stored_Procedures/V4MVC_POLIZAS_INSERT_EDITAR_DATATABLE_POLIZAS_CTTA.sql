CREATE PROCEDURE [dbo].[V4MVC_POLIZAS_INSERT_EDITAR_DATATABLE_POLIZAS_CTTA]
(
  @IDDOC INT               = NULL
, @NROPOLIZA NVARCHAR(50)  = NULL
, @ID UNIQUEIDENTIFIER     = NULL
, @FECINI NVARCHAR(8)      = NULL
, @FECFIN NVARCHAR(8)      = NULL
, @EMPRESA NVARCHAR(10)    = NULL
, @DIVISION NVARCHAR(4)    = NULL
, @USUARIOMOD NVARCHAR(10) = NULL
, @OST NVARCHAR(14)        = NULL
) 
AS
BEGIN

    INSERT INTO POLIZAS( NROPOLIZA		,IDDOC					,FECINI					    ,FECFIN	
						,EMPRESA		,DIVISION				,ID						    ,VALIDADO	
						,USUARIOMOD		,FECHAMOD				,HORAMOD				    ,OST)
			    VALUES( @NROPOLIZA		,@IDDOC					,@FECINI				    ,@FECFIN	
						,@EMPRESA		,@DIVISION				,@ID					    ,'NO'		
						,@USUARIOMOD	,[dbo].[hoy](GETDATE())	,[dbo].[ahora](GETDATE())	,@OST)

END
