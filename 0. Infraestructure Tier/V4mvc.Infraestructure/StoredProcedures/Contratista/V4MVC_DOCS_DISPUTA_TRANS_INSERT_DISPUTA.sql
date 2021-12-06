CREATE PROCEDURE [dbo].[V4MVC_DOCS_DISPUTA_TRANS_INSERT_DISPUTA]
( @ID                 uniqueidentifier = NULL
, @ID_DOC             int = NULL
, @DIVISION           nvarchar(50) = NULL
, @EMPRESA            nvarchar(10) = NULL
, @PATENTE                nvarchar(10) = NULL
, @OBSERVACION        nvarchar(1000) = NULL
, @USUARIO            nvarchar(10) = NULL
, @CERTUSUARIO        nvarchar(10) = NULL
, @ESTADO             nvarchar(2) = NULL
, @VALIDADO           nvarchar(2) = NULL ) AS 
BEGIN

   INSERT INTO [DOCS_DISPUTA_TRANS]
	( ID	, ID_DOC		, DIVISION	, EMPRESA
	, PATENTE	, OBSERVACION	, USUARIO	, FECHA
	, HORA	, CERTUSUARIO	, CERTFECHA	, CERTHORA
	, ESTADO, VALIDADO   )
   VALUES
        ( @ID        , @ID_DOC            , @DIVISION     , @EMPRESA   
        , @PATENTE       , @OBSERVACION       , @USUARIO      , [dbo].[hoy](GETDATE())      
        , [dbo].[ahora](GETDATE())       , @CERTUSUARIO       , [dbo].[hoy](GETDATE()) , [dbo].[ahora](GETDATE()) 
        , @ESTADO    , @VALIDADO )

	DECLARE @ID_DISPUTA INT = SCOPE_IDENTITY()

	DECLARE @USUARIO_ NVARCHAR(10)
	DECLARE	@ID_TIPO_RECHAZO INT
	DECLARE Disputa_Rechazos CURSOR FOR

	SELECT ID_TIPO_RECHAZO, USUARIO FROM DOCS_TRANSPORT_RECHAZO WHERE ID = @ID AND PATENTE = @PATENTE AND ID_DOC = @ID_DOC
	OPEN Disputa_Rechazos

	FETCH Disputa_Rechazos INTO    @ID_TIPO_RECHAZO, @USUARIO_

	WHILE (@@FETCH_STATUS = 0 )
		BEGIN
			INSERT INTO DOCS_DISPUTA_TRANS_RECHAZO(PATENTE, ID_DOC, ID, USUARIO, ID_TIPO_RECHAZO,ID_DISPUTA)
			                                VALUES(@PATENTE,@ID_DOC,@ID,@USUARIO_,@ID_TIPO_RECHAZO,@ID_DISPUTA)
			FETCH Disputa_Rechazos INTO  @ID_TIPO_RECHAZO, @USUARIO_

		END
	CLOSE Disputa_Rechazos
	DEALLOCATE Disputa_Rechazos
	

END
