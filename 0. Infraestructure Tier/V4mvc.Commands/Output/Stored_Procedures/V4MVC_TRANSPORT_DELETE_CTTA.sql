CREATE PROCEDURE [dbo].[V4MVC_TRANSPORT_DELETE_CTTA]
( @PATENTE           nvarchar(8) = NULL
, @TIPO              int = NULL
, @IDEMPRESA		 nvarchar(10) = NULL
, @USUARIO			 nvarchar(10) = NULL)AS
BEGIN
	DECLARE @DSCTIPOV NVARCHAR(50)
	SELECT @DSCTIPOV = DSCTIPOV FROM TYPETRANS WHERE IDTIPO = @TIPO
	INSERT INTO TRANSPORT_HIST( EMPRESA		, PATENTE	, TIPOVEHICULO	,RUT
							  , FECHA		, HORA		, ACCION) 
						VALUES(@IDEMPRESA	, @PATENTE	, @DSCTIPOV		,@USUARIO
							  , [dbo].[hoy](GETDATE())	, [dbo].[ahora](GETDATE()) ,'ELIMINA')

	UPDATE TRANSPORT SET EMPRESA='' WHERE PATENTE = @PATENTE

END


