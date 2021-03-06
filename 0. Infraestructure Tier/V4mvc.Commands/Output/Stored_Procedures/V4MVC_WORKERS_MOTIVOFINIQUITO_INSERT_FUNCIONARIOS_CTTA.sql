CREATE PROCEDURE [dbo].[V4MVC_WORKERS_MOTIVOFINIQUITO_INSERT_FUNCIONARIOS_CTTA]
(
  @RUT            NVARCHAR(10) = NULL
 ,@EMPRESA        NVARCHAR(10) = NULL
 ,@ID_DOC         INT = NULL
 ,@IDARCHIVO      UNIQUEIDENTIFIER = NULL
 ,@MOTIVO         NVARCHAR(20) = NULL
 ,@USRREGISTRA    NVARCHAR(20) = NULL
 ,@FECHAREGISTRA  NVARCHAR(8) = NULL
 ,@HORAREGISTRA   NVARCHAR(8) = NULL
 ,@USRMOD         NVARCHAR(20) = NULL
 ,@FECHAMOD       NVARCHAR(8) = NULL
 ,@HORAMOD        NVARCHAR(8) = NULL
) AS 
BEGIN
	IF(@FECHAMOD IS NULL OR @FECHAMOD = '')
		BEGIN
			SET @FECHAMOD = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd ; DBO.HOY(GETDATE()) */
		END
	IF(@HORAMOD IS NULL OR @HORAMOD = '')
		BEGIN
			SET @HORAMOD = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss ; DBO.AHORA(GETDATE())*/
		END
	IF(@FECHAREGISTRA IS NULL OR @FECHAREGISTRA = '')
		BEGIN
			SET @FECHAREGISTRA = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
		END
	IF(@HORAREGISTRA IS NULL OR @HORAREGISTRA = '')
		BEGIN
			SET @HORAREGISTRA = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
		END
   INSERT INTO WORKERS_MOTIVOFINIQUITO
        ( RUT    , EMPRESA     , ID_DOC        , IDARCHIVO   
        , MOTIVO , USRREGISTRA , FECHAREGISTRA , HORAREGISTRA
        , USRMOD , FECHAMOD    , HORAMOD       )
   VALUES
        ( @RUT    , @EMPRESA     , @ID_DOC , @IDARCHIVO   
        , @MOTIVO , @USRREGISTRA , @FECHAREGISTRA, @HORAREGISTRA
        , @USRMOD , @FECHAMOD , @HORAMOD)

END


