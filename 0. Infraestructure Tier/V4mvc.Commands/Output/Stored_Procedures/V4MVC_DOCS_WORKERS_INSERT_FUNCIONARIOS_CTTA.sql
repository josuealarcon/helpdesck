CREATE PROCEDURE [dbo].[V4MVC_DOCS_WORKERS_INSERT_FUNCIONARIOS_CTTA]
(
   @RUT              NVARCHAR(10) = NULL
  ,@ID_DOC           INT = NULL
  ,@FECHA_MOD        NVARCHAR(8) = NULL
  ,@HORA_MOD         NVARCHAR(8) = NULL
  ,@USUARIO          NVARCHAR(10) = NULL
  ,@ID               UNIQUEIDENTIFIER = NULL
  ,@VALIDADO         NVARCHAR(2) = 'NO'
  ,@DIVISION         NVARCHAR(4) = NULL
  ,@EMPRESA          NVARCHAR(10) = NULL
  ,@FECHASUBE        NVARCHAR(8) = NULL
  ,@HORASUBE         NVARCHAR(8) = NULL
) AS 
BEGIN

	IF(@FECHA_MOD IS NULL OR @FECHA_MOD = '')
		BEGIN
			SET @FECHA_MOD = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
		END
	IF(@HORA_MOD IS NULL OR @HORA_MOD = '')
		BEGIN
			SET @HORA_MOD = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
		END
	IF(@FECHASUBE IS NULL OR @FECHASUBE = '')
		BEGIN
			SET @FECHASUBE = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
		END
	IF(@HORASUBE IS NULL OR @HORASUBE = '')
		BEGIN
			SET @HORASUBE = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
		END

	INSERT INTO DOCS_WORKERS
        ( RUT             , ID_DOC         , FECHA_MOD		, HORA_MOD        
		, USUARIO		  , ID             , VALIDADO       , DIVISION        
		, EMPRESA         , FECHASUBE      , HORASUBE    )
	VALUES
        ( @RUT            , @ID_DOC         , @FECHA_MOD	, @HORA_MOD        
		, @USUARIO		  , @ID             , @VALIDADO     , @DIVISION        
		, @EMPRESA        , @FECHASUBE      , @HORASUBE    )


END


