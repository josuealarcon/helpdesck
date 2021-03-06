CREATE PROCEDURE [dbo].[V4MVC_DOCS_OST_PREVENCIONISTA_UPDATE_CONTRATOST_CTTA]
(
  @NUM_SOLICITUD	INT
 ,@RUT				NVARCHAR(10)
 ,@NOMBRES			NVARCHAR(50)
 ,@APELLIDOS		NVARCHAR(50)
 ,@IDEMPRESA		NVARCHAR(10)
 ,@FONO				NVARCHAR(50)
 ,@EMAIL			NVARCHAR(50)
 ,@USUARIO			NVARCHAR(10)
 ,@ESTADO_ANTERIOR	NVARCHAR(2)
 ,@ID_ARCHIVO		UNIQUEIDENTIFIER
) AS
BEGIN
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	DECLARE @SUMA_MESES_120 NVARCHAR(8) = convert(NVARCHAR(8), DATEADD(MONTH, 120, GETDATE()), 112) /* yyyymmdd */

	UPDATE DOCS_OST_PREVENCIONISTA
	SET
		ID_ARCHIVO = @ID_ARCHIVO
	WHERE ID = @NUM_SOLICITUD

	IF(NOT EXISTS(
		(
			SELECT * FROM WORKERS WHERE RUT = @RUT
		)
	))
		BEGIN
			INSERT INTO WORKERS (RUT, NOMBRES, APELLIDOS) VALUES(@RUT, @NOMBRES, @APELLIDOS)
			INSERT INTO WORKERSLOCAL
			(
			RUT, EMPRESA, DIVISION, TIPOPASE, FINIPASE,
			FFINPASE, AUTOR, LOTE, OST)
			VALUES
			(
			@RUT, @IDEMPRESA, 'LB', 'TRABAJO',
			@CURR_FECHA, @SUMA_MESES_120, 'NO', 0, 'NOMINA')
		END

	IF(NOT EXISTS(
			(
				SELECT * FROM DIRECCION WHERE RUT = @RUT
			)
		))
		BEGIN
			INSERT INTO DIRECCION (RUT, FONO, EMAIL) VALUES(@RUT, @FONO, @EMAIL)
		END
	ELSE
		BEGIN
			UPDATE DIRECCION
			SET
				FONO = @FONO,
				EMAIL = @EMAIL
			WHERE RUT = @RUT
		END

	IF(EXISTS(
			(
				SELECT * FROM DOCS_OST_PREVENCIONISTA WHERE ID = @NUM_SOLICITUD
			)
		))
		BEGIN
			IF(@ESTADO_ANTERIOR <> 'SI' OR @ESTADO_ANTERIOR <> 'RE')
				BEGIN
								UPDATE DOCS_OST_PREVENCIONISTA
								SET
									ESTADO = 'PE',
									RUT_PREVENCIONISTA = @RUT,
									USRSUBE = @USUARIO,
									FECHASUBE = @CURR_FECHA,
									HORASUBE = @CURR_TIEMPOFULL,
									USRMOD = @USUARIO,
									FECHAMOD = @CURR_FECHA,
									HORAMOD = @CURR_TIEMPOFULL
								WHERE ID = @NUM_SOLICITUD
				END
			ELSE
				BEGIN
								UPDATE DOCS_OST_PREVENCIONISTA
								SET
									RUT_PREVENCIONISTA = @RUT,
									USRSUBE = @USUARIO,
									FECHASUBE = @CURR_FECHA,
									HORASUBE = @CURR_TIEMPOFULL,
									USRMOD = @USUARIO,
									FECHAMOD = @CURR_FECHA,
									HORAMOD = @CURR_TIEMPOFULL
								WHERE ID = @NUM_SOLICITUD
				END

			/*********************************/
			INSERT INTO DOCS_OST_PREVENCIONISTA_HIST
				(
				ID, OST, EMPRESA, DOTACION, USRCREACION, FECHACREACION,
				HORACREACION, APORTE_ANGLO, MOTIVO, RUT_PREVENCIONISTA,
				ID_ARCHIVO, ESTADO, USRSUBE, FECHASUBE, HORASUBE, CERTUSUARIO,
				CERTFECHA, CERTHORA, OBSERVACION, USRAPORTE, FECHAAPORTE,
				HORAAPORTE, USRMOD, FECHAMOD, HORAMOD)
			SELECT
				ID, OST, EMPRESA, DOTACION, USRCREACION, FECHACREACION,
				HORACREACION, APORTE_ANGLO, MOTIVO, RUT_PREVENCIONISTA,
				ID_ARCHIVO, ESTADO, USRSUBE, FECHASUBE, HORASUBE, CERTUSUARIO,
				CERTFECHA, CERTHORA, OBSERVACION, USRAPORTE, FECHAAPORTE, HORAAPORTE,
				USRMOD, FECHAMOD, HORAMOD
			FROM DOCS_OST_PREVENCIONISTA
			WHERE ID = @NUM_SOLICITUD
		END

END

