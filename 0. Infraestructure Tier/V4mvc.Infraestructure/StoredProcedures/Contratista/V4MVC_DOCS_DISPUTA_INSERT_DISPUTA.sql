CREATE PROCEDURE [dbo].[V4MVC_DOCS_DISPUTA_INSERT_DISPUTA]
( @ID                 uniqueidentifier = NULL
, @ID_DOC             int = NULL
, @DIVISION           nvarchar(50) = NULL
, @EMPRESA            nvarchar(10) = NULL
, @RUT                nvarchar(10) = NULL
, @OBSERVACION        nvarchar(1000) = NULL
, @USUARIO            nvarchar(10) = NULL
, @CERTUSUARIO        nvarchar(10) = NULL
, @CERTFECHA          nvarchar(8) = NULL
, @CERTHORA           nvarchar(8) = NULL
, @ESTADO             nvarchar(2) = NULL
, @VALIDADO           nvarchar(2) = NULL ) AS 
BEGIN

   INSERT INTO [DOCS_DISPUTA]
	( ID	, ID_DOC		, DIVISION	, EMPRESA
	, RUT	, OBSERVACION	, USUARIO	, FECHA
	, HORA	, CERTUSUARIO	, CERTFECHA	, CERTHORA
	, ESTADO, VALIDADO   )
   VALUES
        ( @ID        , @ID_DOC            , @DIVISION     , @EMPRESA   
        , @RUT       , @OBSERVACION       , @USUARIO      , [dbo].[hoy](GETDATE())      
        , [dbo].[ahora](GETDATE())       , @CERTUSUARIO       , @CERTFECHA    , @CERTHORA  
        , @ESTADO    , @VALIDADO )

	DECLARE @ID_DISPUTA INT = SCOPE_IDENTITY()

	DECLARE @USUARIO_ NVARCHAR(10)
	DECLARE	@ID_TIPO_RECHAZO INT
	DECLARE Disputa_Rechazos CURSOR FOR

	SELECT ID_TIPO_RECHAZO, USUARIO FROM DOCS_WORKERS_RECHAZO WHERE ID = @ID AND RUT = @RUT AND ID_DOC = @ID_DOC
	OPEN Disputa_Rechazos

	FETCH Disputa_Rechazos INTO    @USUARIO_ , @ID_TIPO_RECHAZO

	WHILE (@@FETCH_STATUS = 0 )
		BEGIN
			INSERT INTO DOCS_DISPUTA_RECHAZO(ID_DISPUTA, RUT, ID_DOC, ID, USUARIO, ID_TIPO_RECHAZO)
			VALUES(@ID_DISPUTA,@RUT,@ID_DOC,@ID,@USUARIO_,@ID_TIPO_RECHAZO)
			FETCH AsignacionClinica INTO @USUARIO_ , @ID_TIPO_RECHAZO

		END
	CLOSE Disputa_Rechazos
	DEALLOCATE Disputa_Rechazos
	

END

