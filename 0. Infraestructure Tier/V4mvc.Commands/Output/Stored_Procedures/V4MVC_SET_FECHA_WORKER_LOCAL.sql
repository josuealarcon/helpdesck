CREATE PROCEDURE [dbo].[V4MVC_SET_FECHA_WORKER_LOCAL]
(
@ID_DOC_FEC		INT = NULL
,@RUT			NVARCHAR(8) = NULL
,@DIVCOD			NVARCHAR(4) = NULL
,@IDEMPRESA			NVARCHAR(11) = NULL
,@FECHA				NVARCHAR(8) = NULL
,@USUARIO			NVARCHAR(11) = NULL
)
AS
BEGIN
	DECLARE @EMP_COMUN INT = 0
	DECLARE @DIV_COMUN INT = 0
	DECLARE @VAL_FECHA NVARCHAR(8) = ''
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	SELECT @EMP_COMUN = D.COMUN, @DIV_COMUN = DF.COMUN  
	FROM DOCS_FEC AS DF 
	INNER JOIN DOCS AS D ON DF.ID_DOC_DEPEND = D.ID_DOC 
	WHERE  (DF.ID_DOC_FEC = @ID_DOC_FEC)
	IF(@FECHA = '19000101')
		BEGIN
			IF(@EMP_COMUN = 0)
				BEGIN
					IF(@DIV_COMUN = 0)
						BEGIN
							DELETE FROM DOCS_FEC_WORKERS WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (DIVISION = @DIVCOD) AND (EMPRESA = @IDEMPRESA)
						END
					ELSE
						BEGIN
							DELETE FROM DOCS_FEC_WORKERS WHERE (RUT = @RUT) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (EMPRESA = @IDEMPRESA)
						END
				END
			ELSE
				BEGIN
					DELETE FROM DOCS_FEC_WORKERS WHERE (RUT = @RUT) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (DIVISION = @DIVCOD)
				END
		END
	ELSE
		BEGIN
			IF(@EMP_COMUN = 0)
				BEGIN
					IF(@DIV_COMUN = 0)
						BEGIN
							SELECT TOP 1 @VAL_FECHA = FECHA FROM DOCS_FEC_WORKERS WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (DIVISION = @DIVCOD) AND (EMPRESA = @IDEMPRESA) ORDER BY FECHA DESC
						END
					ELSE
						BEGIN
							SELECT TOP 1 @VAL_FECHA = FECHA FROM DOCS_FEC_WORKERS WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (EMPRESA = @IDEMPRESA) ORDER BY FECHA DESC
						END
				END
			ELSE
				BEGIN
					IF(@DIV_COMUN = 0)
						BEGIN
							SELECT TOP 1 @VAL_FECHA = FECHA FROM DOCS_FEC_WORKERS WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (DIVISION = @DIVCOD) ORDER BY FECHA DESC
						END
					ELSE
						BEGIN
							SELECT TOP 1 @VAL_FECHA = FECHA FROM DOCS_FEC_WORKERS WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) ORDER BY FECHA DESC
						END
				END
			/*----- -------*/
			IF(@VAL_FECHA IS NOT NULL AND @VAL_FECHA <> '')
				BEGIN
					IF(@EMP_COMUN = 0)
						BEGIN
							IF(@DIV_COMUN = 0)
								BEGIN
									UPDATE DOCS_FEC_WORKERS
										SET FECHA = @FECHA,
											FECHAMOD = @CURR_FECHA,
											HORAMOD = @CURR_TIEMPOFULL,
											USUARIO = @USUARIO,
											EMPRESA = @IDEMPRESA
										WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (EMPRESA = @IDEMPRESA) AND (DIVISION = @DIVCOD)
								END
							ELSE
								BEGIN
									UPDATE DOCS_FEC_WORKERS
										SET FECHA = @FECHA,
											FECHAMOD = @CURR_FECHA,
											HORAMOD = @CURR_TIEMPOFULL,
											USUARIO = @USUARIO,
											EMPRESA = @IDEMPRESA
										WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (EMPRESA = @IDEMPRESA)
								END
						END
					ELSE
						BEGIN
							IF(@DIV_COMUN = 0)
								BEGIN
									UPDATE DOCS_FEC_WORKERS
										SET FECHA = @FECHA,
											FECHAMOD = @CURR_FECHA,
											HORAMOD = @CURR_TIEMPOFULL,
											USUARIO = @USUARIO,
											EMPRESA = @IDEMPRESA
										WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC) AND (DIVISION = @DIVCOD)
								END
							ELSE
								BEGIN
									UPDATE DOCS_FEC_WORKERS
										SET FECHA = @FECHA,
											FECHAMOD = @CURR_FECHA,
											HORAMOD = @CURR_TIEMPOFULL,
											USUARIO = @USUARIO,
											EMPRESA = @IDEMPRESA
										WHERE (RUT = @RUT ) AND (ID_DOC_FEC = @ID_DOC_FEC)
								END
						END					
				END
			ELSE
				BEGIN
					INSERT INTO DOCS_FEC_WORKERS (RUT, ID_DOC_FEC, EMPRESA, DIVISION, FECHA, FECHAMOD, HORAMOD, USUARIO) VALUES(@RUT, @ID_DOC_FEC, @IDEMPRESA, @DIVCOD, @FECHA, @CURR_FECHA, @CURR_TIEMPOFULL, @USUARIO);
				END
		END

	INSERT INTO DOCS_FEC_WORKERS_HST (RUT, ID_DOC_FEC, EMPRESA, DIVISION, FECHA, FECHAMOD, HORAMOD, USUARIO) VALUES(@RUT, @ID_DOC_FEC, @IDEMPRESA, @DIVCOD, @FECHA, @CURR_FECHA, @CURR_TIEMPOFULL, @USUARIO);

END
