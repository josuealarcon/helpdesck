CREATE PROCEDURE [dbo].[V4MVC_POLIZA_MUERTE_UPDATE_V2_CONTROLLABORAL_CTTA]
(
  @IDEMPRESA			NVARCHAR(10)
 ,@PERIODO				NVARCHAR(6)
 ,@ID					UNIQUEIDENTIFIER
 ,@USUARIO				NVARCHAR(10)
 ,@DISPUTA_ID			INT
 ,@DISPUTA_EXISTE		INT OUTPUT
 ,@DISPUTA_EMPRESA		NVARCHAR(12) OUTPUT
 ,@DISPUTA_FECHA		NVARCHAR(8) OUTPUT
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */

	DECLARE @DDC_ID_DISPUTA INT
	DECLARE @DDC_ID_DOC INT
	DECLARE @DDC_ID UNIQUEIDENTIFIER
	DECLARE @DDC_USUARIO NVARCHAR(10)
	DECLARE @DDC_HORA NVARCHAR(8)
	DECLARE @DDC_OBSERVACION NVARCHAR(1000)
	DECLARE @DDC_CERTUSUARIO NVARCHAR(10)
	DECLARE @DDC_CERTFECHA NVARCHAR(8)
	DECLARE @DDC_CERTHORA NVARCHAR(8)
	DECLARE @DDC_ESTADO NVARCHAR(2)
	DECLARE @DDC_REVALUSUARIO NVARCHAR(10)
	DECLARE @DDC_REVALFECHA NVARCHAR(8)
	DECLARE @DDC_REVALHORA NVARCHAR(8)
	DECLARE @DDC_OBSERVACION_REVAL NVARCHAR(1000)
	DECLARE @DDC_VALIDADO NVARCHAR(2)
	DECLARE @DDC_PERIODO NVARCHAR(6)
	DECLARE @DDC_ID_CERTIFICADO INT

	SET @DISPUTA_EXISTE = 0

	SELECT
		TOP 1
		@DISPUTA_EXISTE = 1,
		@DDC_ID_DISPUTA = ID_DISPUTA,
		@DISPUTA_EMPRESA = EMPRESA,
		@DDC_ID_DOC = ID_DOC,
		@DDC_ID = ID,
		@DDC_USUARIO = USUARIO,
		@DISPUTA_FECHA = FECHA,
		@DDC_HORA = HORA,
		@DDC_OBSERVACION = OBSERVACION,
		@DDC_CERTUSUARIO = CERTUSUARIO,
		@DDC_CERTFECHA = CERTFECHA,
		@DDC_CERTHORA = CERTHORA,
		@DDC_ESTADO = ESTADO,
		@DDC_REVALUSUARIO = REVALUSUARIO,
		@DDC_REVALFECHA = REVALFECHA,
		@DDC_REVALHORA = REVALHORA,
		@DDC_OBSERVACION_REVAL = OBSERVACION_REVAL,
		@DDC_VALIDADO = VALIDADO,
		@DDC_PERIODO = PERIODO,
		@DDC_ID_CERTIFICADO = ID_CERTIFICADO
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
			VALUES 
				(
					@DDC_ID_DISPUTA,
					@DISPUTA_EMPRESA,
					@DDC_ID_DOC,
					@DDC_ID,
					@DDC_USUARIO,
					@DISPUTA_FECHA,
					@DDC_HORA,
					@DDC_OBSERVACION,
					@DDC_CERTUSUARIO,
					@DDC_CERTFECHA,
					@DDC_CERTHORA,
					@DDC_ESTADO,
					@DDC_REVALUSUARIO,
					@DDC_REVALFECHA,
					@DDC_REVALHORA,
					@DDC_OBSERVACION_REVAL,
					@DDC_VALIDADO,
					@DDC_PERIODO,
					@DDC_ID_CERTIFICADO,
					@USUARIO,
					@CURR_FECHA,
					@CURR_TIEMPOFULL,
					'ELIMINADO'
				)

			DELETE DOCS_DISPUTA_CLABORAL
			WHERE
				ID_DISPUTA = @DISPUTA_ID AND
				ESTADO = 'NO'
		END

		DELETE FROM ARCHIVOS
		WHERE ID = @ID

		UPDATE POLIZA_MUERTE
		SET
			ID = NULL,
			VALIDADO = 'NO',
			USUARIO = @USUARIO,
			FECHAMOD = @CURR_FECHA,
			HORAMOD = @CURR_TIEMPOFULL
		WHERE
			EMPRESA = @IDEMPRESA AND
			PERIODO = @PERIODO

END
