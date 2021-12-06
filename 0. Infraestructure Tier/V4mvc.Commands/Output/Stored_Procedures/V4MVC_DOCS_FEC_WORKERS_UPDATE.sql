CREATE PROCEDURE [dbo].[V4MVC_DOCS_FEC_WORKERS_UPDATE]
( @RUT         nvarchar(10) = NULL
, @DIVISION    nvarchar(20) = NULL
, @EMPRESA     nvarchar(10) = NULL
, @ID_DOC_FEC  int = NULL
, @FECHA       nvarchar(8) = NULL
, @FECHAMOD    nvarchar(8) = NULL
, @HORAMOD     nvarchar(8) = NULL
, @USUARIO     nvarchar(10) = NULL ) AS 
BEGIN

   UPDATE [DOCS_FEC_WORKERS]
      SET [EMPRESA]    = @EMPRESA
        , [FECHA]      = @FECHA
        , [FECHAMOD]   = DBO.HOY(GETDATE())
        , [HORAMOD]    = DBO.AHORA(GETDATE())
        , [USUARIO]    = @USUARIO
	WHERE	[ID_DOC_FEC] = @ID_DOC_FEC
	AND		[RUT]        = @RUT

	INSERT INTO DOCS_FEC_WORKERS_HST
		(RUT	, DIVISION	, EMPRESA	, ID_DOC_FEC	 
	   , FECHA	, FECHAMOD	, HORAMOD	, USUARIO) 
	VALUES
		( @RUT   , @DIVISION , @EMPRESA , @ID_DOC_FEC
        , @FECHA , DBO.HOY(GETDATE()) , DBO.AHORA(GETDATE()) , @USUARIO    )

END


