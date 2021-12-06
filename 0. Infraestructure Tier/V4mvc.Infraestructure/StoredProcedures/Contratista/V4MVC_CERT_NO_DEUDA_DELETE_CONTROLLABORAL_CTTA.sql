CREATE PROCEDURE [dbo].[V4MVC_CERT_NO_DEUDA_DELETE_CONTROLLABORAL_CTTA]
(
  @IDEMPRESA		NVARCHAR(10)
 ,@PERIODO			NVARCHAR(6)
 ,@OST				NVARCHAR(14)
 ,@USUARIO			NVARCHAR(10)
 ,@DISPUTA_ID		INT
 ,@DISPUTA_EXISTE	INT OUTPUT
 ,@DISPUTA_EMPRESA	NVARCHAR(12) OUTPUT
 ,@DISPUTA_FECHA	NVARCHAR(8) OUTPUT
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */

	DECLARE @CND_EXISTS BIT = 0
	DECLARE @CND_EMPRESA NVARCHAR(10)
	DECLARE @CND_PERIODO NVARCHAR(6)

	DECLARE @CND_OST NVARCHAR(14)
	
	DECLARE @CND_VALIDADO NVARCHAR(2)
	DECLARE @CND_ID UNIQUEIDENTIFIER
	DECLARE @CND_OBSERVACION NVARCHAR(500)
	DECLARE @CND_USUARIO NVARCHAR(10)
	DECLARE @CND_FECHASUBE NVARCHAR(8)
	DECLARE @CND_HORASUBE NVARCHAR(8)
	DECLARE @CND_CERTUSUARIO NVARCHAR(10)
	DECLARE @CND_CERTFECHA NVARCHAR(8)
	DECLARE @CND_CERTHORA NVARCHAR(8)

	DECLARE @DSP_ID_DISPUTA INT
	DECLARE @DSP_ID_DOC INT
	DECLARE @DSP_ID UNIQUEIDENTIFIER
	DECLARE @DSP_USUARIO NVARCHAR(10)
	DECLARE @DSP_HORA NVARCHAR(8)
	DECLARE @DSP_OBSERVACION NVARCHAR(1000)
	DECLARE @DSP_CERTUSUARIO NVARCHAR(10)
	DECLARE @DSP_CERTFECHA NVARCHAR(8)
	DECLARE @DSP_CERTHORA NVARCHAR(8)
	DECLARE @DSP_ESTADO	NVARCHAR(2)
	DECLARE @DSP_REVALUSUARIO NVARCHAR(10)
	DECLARE @DSP_REVALFECHA	NVARCHAR(8)
	DECLARE @DSP_REVALHORA	NVARCHAR(8)
	DECLARE @DSP_OBSERVACION_REVAL	NVARCHAR(1000)
	DECLARE @DSP_VALIDADO NVARCHAR(2)
	DECLARE @DSP_PERIODO NVARCHAR(6)
	DECLARE @DSP_ID_CERTIFICADO INT

	SET @DISPUTA_EXISTE = 0
	SET @DISPUTA_EMPRESA = ''
	SET @DISPUTA_FECHA = ''

	SELECT
		TOP 1
		@CND_EXISTS = 1,
		@CND_EMPRESA = EMPRESA,
		@CND_PERIODO = PERIODO,

		@CND_OST = OST,

		@CND_VALIDADO = VALIDADO,
		@CND_ID = ID,
		@CND_OBSERVACION = OBSERVACION,
		@CND_USUARIO = USUARIO,
		@CND_FECHASUBE = FECHASUBE,
		@CND_HORASUBE = HORASUBE,
		@CND_CERTUSUARIO = CERTUSUARIO,
		@CND_CERTFECHA = CERTFECHA,
		@CND_CERTHORA = CERTHORA
	FROM CERT_NO_DEUDA
	WHERE
		EMPRESA = @IDEMPRESA AND
		PERIODO = @PERIODO

	IF(@CND_EXISTS = 1)
		BEGIN
			INSERT INTO CERT_NO_DEUDA_LOG
						(
							EMPRESA,
							PERIODO,
							OST,
							ID,
							USUARIO,
							FECHASUBE,
							HORASUBE,
							VALIDADO,
							OBSERVACION,
							CERTUSUARIO,
							CERTFECHA,
							CERTHORA,
							USUARIODEL,
							FECHADEL,
							HORADEL
						)
			VALUES
						(
							@CND_EMPRESA,
							@CND_PERIODO,
							@OST,
							@CND_ID,
							@CND_USUARIO,
							@CND_FECHASUBE,
							@CND_HORASUBE,
							@CND_VALIDADO,
							@CND_OBSERVACION,
							@CND_CERTUSUARIO,
							@CND_CERTFECHA,
							@CND_CERTHORA,
							@USUARIO,
							@CURR_FECHA,
							@CURR_TIEMPOFULL
						)
			/*--------------------------*/

			
			SELECT
				TOP 1
				@DISPUTA_EXISTE = 1,
				@DSP_ID_DISPUTA = ID_DISPUTA,
				@DISPUTA_EMPRESA = EMPRESA,
				@DSP_ID_DOC = ID_DOC,
				@DSP_ID = ID,
				@DSP_USUARIO = USUARIO,
				@DISPUTA_FECHA = FECHA,
				@DSP_HORA = HORA,
				@DSP_OBSERVACION = OBSERVACION,
				@DSP_CERTUSUARIO = CERTUSUARIO,
				@DSP_CERTFECHA = CERTFECHA,
				@DSP_CERTHORA = CERTHORA,
				@DSP_ESTADO = ESTADO,
				@DSP_REVALUSUARIO = REVALUSUARIO,
				@DSP_REVALFECHA = REVALFECHA,
				@DSP_REVALHORA = REVALHORA,
				@DSP_OBSERVACION_REVAL = OBSERVACION_REVAL,
				@DSP_VALIDADO = VALIDADO,
				@DSP_PERIODO = PERIODO,
				@DSP_ID_CERTIFICADO = ID_CERTIFICADO
			FROM DOCS_DISPUTA_CLABORAL
			WHERE
				ID_DISPUTA = @DISPUTA_ID AND
				ESTADO = 'NO'

			IF(@DISPUTA_EXISTE = 1)
				BEGIN
					INSERT INTO DOCS_DISPUTA_CLABORAL_LOG
							(
								ID_DISPUTA,
								EMPRESA,
								ID_DOC,
								ID,
								USUARIO,
								FECHA,
								HORA,
								OBSERVACION,
								CERTUSUARIO,
								CERTFECHA,
								CERTHORA,
								ESTADO,
								REVALUSUARIO,
								REVALFECHA,
								REVALHORA,
								OBSERVACION_REVAL,
								VALIDADO,
								PERIODO,
								ID_CERTIFICADO,
								USRMOD,
								FECHAMOD,
								HORAMOD,
								ACCION
							)
					VALUES (
								@DSP_ID_DISPUTA,
								@DISPUTA_EMPRESA,
								@DSP_ID_DOC,
								@DSP_ID,
								@DSP_USUARIO,
								@DISPUTA_FECHA,
								@DSP_HORA,
								@DSP_OBSERVACION,
								@DSP_CERTUSUARIO,
								@DSP_CERTFECHA,
								@DSP_CERTHORA,
								@DSP_ESTADO,
								@DSP_REVALUSUARIO,
								@DSP_REVALFECHA,
								@DSP_REVALHORA,
								@DSP_OBSERVACION_REVAL,
								@DSP_VALIDADO,
								@DSP_PERIODO,
								@DSP_ID_CERTIFICADO,
								@USUARIO,
								@CURR_FECHA,
								@CURR_TIEMPOFULL,
								'ELIMINADO'
							)

					DELETE DOCS_DISPUTA_CLABORAL WHERE ID_DISPUTA = @DISPUTA_ID AND ESTADO = 'NO'
				END

			DELETE FROM CERT_NO_DEUDA
			WHERE
				PERIODO = @PERIODO AND
				EMPRESA = @IDEMPRESA AND
				OST = @OST

		END
END
