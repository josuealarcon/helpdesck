CREATE PROCEDURE [dbo].[V4MVC_REMUNERACIONES_PROPIO_DELETE_CONTROLLABORAL_CTTA]
(
  @IDEMPRESA		NVARCHAR(10)
 ,@PERIODO			NVARCHAR(6)
 ,@DIVISION			NVARCHAR(4)
 ,@OST				NVARCHAR(20)
 ,@ID_DOC			INT
 ,@USUARIO			NVARCHAR(10)
 ,@DISPUTA_ID		INT
 ,@DISPUTA_EXISTE	INT OUTPUT
 ,@DISPUTA_EMPRESA	NVARCHAR(12) OUTPUT
 ,@DISPUTA_FECHA	NVARCHAR(8) OUTPUT
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */

	DECLARE @RP_EXISTS BIT = 0
	DECLARE @RP_EMPRESA NVARCHAR(10)
	DECLARE @RP_PERIODO NVARCHAR(6)
	
	DECLARE @RP_DIVISION NVARCHAR(4)
	DECLARE @RP_OST NVARCHAR(20)
	
	DECLARE @RP_VALIDADO NVARCHAR(2)
	DECLARE @RP_ID UNIQUEIDENTIFIER
	DECLARE @RP_OBSERVACION NVARCHAR(500)
	DECLARE @RP_USUARIO NVARCHAR(20)
	DECLARE @RP_FECHAMOD NVARCHAR(8)
	DECLARE @RP_HORAMOD NVARCHAR(8)
	DECLARE @RP_CERTUSUARIO NVARCHAR(20)
	DECLARE @RP_CERTFECHA NVARCHAR(8)
	DECLARE @RP_CERTHORA NVARCHAR(8)

	
	DECLARE @DSP_ID_DISPUTA INT

	DECLARE @DSP_DIVISION NVARCHAR(4)
	DECLARE @DSP_OST NVARCHAR(20)

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
	SET @DISPUTA_FECHA = ''
	SET @DISPUTA_EMPRESA = ''

	SELECT
		TOP 1
		@RP_EXISTS = 1,
		@RP_EMPRESA = EMPRESA,
		@RP_PERIODO = PERIODO,
		@RP_DIVISION = DIVISION,
		@RP_OST = OST,
		@RP_VALIDADO = VALIDADO,
		@RP_ID = ID,
		@RP_OBSERVACION = OBSERVACION,
		@RP_USUARIO = USUARIO,
		@RP_FECHAMOD = FECHAMOD,
		@RP_HORAMOD = HORAMOD,
		@RP_CERTUSUARIO = CERTUSUARIO,
		@RP_CERTFECHA = CERTFECHA,
		@RP_CERTHORA = CERTHORA
	FROM REMUNERACIONES_PROPIO
	WHERE
		EMPRESA = @IDEMPRESA AND
		PERIODO = @PERIODO AND
		DIVISION = @DIVISION AND
		OST = @OST

	IF(@RP_EXISTS = 1)
		BEGIN
			INSERT INTO REMUNERACIONES_PROPIO_LOG
						(
							EMPRESA,
							PERIODO,
							DIVISION,
							OST,
							ID,
							USUARIO,
							FECHAMOD,
							HORAMOD,
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
							@RP_EMPRESA,
							@RP_PERIODO,
							@RP_DIVISION,
							@RP_OST,
							@RP_ID,
							@RP_USUARIO,
							@RP_FECHAMOD,
							@RP_HORAMOD,
							@RP_VALIDADO,
							@RP_OBSERVACION,
							@RP_CERTUSUARIO,
							@RP_CERTFECHA,
							@RP_CERTHORA,
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
				@DSP_DIVISION = DIVISION,
				@DSP_OST = OST,
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
				ID_DOC = @ID_DOC AND
				ESTADO = 'NO'

			IF(@DISPUTA_EXISTE = 1)
				BEGIN
					INSERT INTO DOCS_DISPUTA_CLABORAL_LOG
							(
								ID_DISPUTA,
								EMPRESA,
								DIVISION,
								OST,
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
								@DSP_DIVISION,
								@DSP_OST,
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

					DELETE DOCS_DISPUTA_CLABORAL
					WHERE
						ID_DISPUTA = @DISPUTA_ID AND
						ID_DOC = @ID_DOC AND
						ESTADO = 'NO'
				END

			DELETE FROM REMUNERACIONES_PROPIO
			WHERE PERIODO = @PERIODO AND
			EMPRESA = @IDEMPRESA AND
			DIVISION = @DIVISION AND
			OST = @OST

		END
END
