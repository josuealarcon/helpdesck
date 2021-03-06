CREATE PROCEDURE [dbo].[V4MVC_CERT_NO_DEUDA_UPDATE_V3_CONTROLLABORAL_CTTA]
(
  @ID			UNIQUEIDENTIFIER = NULL
 ,@USUARIO		NVARCHAR(10)
 ,@PERIODO		NVARCHAR(6)
 ,@IDEMPRESA	NVARCHAR(10)
 ,@OST			NVARCHAR(14)
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	
	IF(@ID IS NOT NULL)
		BEGIN
			UPDATE CERT_NO_DEUDA
			SET
				ID = @ID,
				VALIDADO = 'NO',
				USUARIO = @USUARIO,
				FECHASUBE = @CURR_FECHA,
				HORASUBE = @CURR_TIEMPOFULL
			WHERE
				(EMPRESA = @IDEMPRESA) AND
				(PERIODO = @PERIODO) AND
				(OST = @OST)
		END
	ELSE
		BEGIN
			UPDATE CERT_NO_DEUDA
			SET
				VALIDADO = 'NO',
				USUARIO = @USUARIO,
				FECHASUBE = @CURR_FECHA,
				HORASUBE = @CURR_TIEMPOFULL
			WHERE
				(EMPRESA = @IDEMPRESA) AND
				(PERIODO = @PERIODO) AND
				(OST = @OST)
		END
END
