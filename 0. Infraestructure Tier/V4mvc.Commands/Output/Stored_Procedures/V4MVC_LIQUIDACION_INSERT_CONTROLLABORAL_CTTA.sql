CREATE PROCEDURE [dbo].[V4MVC_LIQUIDACION_INSERT_CONTROLLABORAL_CTTA]
(
  @RUT						NVARCHAR(10)
 ,@PERIODO					NVARCHAR(6)
 ,@EMPRESA					NVARCHAR(10)
 ,@USUARIO					NVARCHAR(10)
 ,@IMPONIBLE				INT
 ,@LIQUIDO					INT
 ,@TRANSFERIDO				INT
 ,@BONOIP					INT
 ,@BONOIS					INT	
 ,@INCLU_F301				NVARCHAR(2)
 ,@OST						NVARCHAR(14)
 ,@RUT_PERIODO_VACIO		INT OUTPUT
 ,@PERIODO_INVALIDO			INT OUTPUT
 ,@RANGO_FECHA_INVALIDO		INT OUTPUT
 ,@RUT_INVALIDO				INT OUTPUT
 ,@REPETIDO					INT OUTPUT
 ,@RUT_ORIGINAL_ERR			NVARCHAR(10) OUTPUT
 ,@RUT_PROCESADO_ERR		NVARCHAR(10) OUTPUT
 ,@PERIODO_ERR				NVARCHAR(6) OUTPUT
) AS
BEGIN
	DECLARE @RUT_PROCESADO NVARCHAR(10)
	DECLARE @MES INT
	DECLARE @ANIO INT
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	
	SET @RUT_PERIODO_VACIO = 0
	SET @PERIODO_INVALIDO = 0
	SET @RANGO_FECHA_INVALIDO = 0
	SET @RUT_INVALIDO = 0
	SET @REPETIDO = 0
	
	SET @RUT_ORIGINAL_ERR = ''
	SET @RUT_PROCESADO_ERR = ''
	SET @PERIODO_ERR = ''

	EXEC @RUT_PROCESADO = [dbo].[V4MVC_RESUELVE_SOLO_RUT]
		@RUT = @RUT


	IF(@RUT_PROCESADO IS NOT NULL AND @RUT_PROCESADO <> '' AND @PERIODO IS NOT NULL AND @PERIODO <> '' )
		BEGIN
			IF(LEN(@PERIODO) = 6)
				BEGIN
					SET @MES = CONVERT(INT, SUBSTRING(@PERIODO, 5, 6))
					SET @ANIO = CONVERT(INT, SUBSTRING(@PERIODO, 1, 4))

					IF(@MES > 0 AND @MES < 13 AND @ANIO > 2000 AND @ANIO < 2100 )
						BEGIN
							IF(@RUT_PROCESADO = @RUT)
								BEGIN
									IF(NOT EXISTS(
											SELECT
												RUT
											FROM LIQUIDACION
											WHERE
												RUT = @RUT_PROCESADO AND
												FECHA = @PERIODO AND
												EMPRESA = @EMPRESA
									))
										BEGIN
											INSERT INTO LIQUIDACION
														(
															RUT,
															FECHA,
															IMPONIBLE,
															LIQUIDO,
															TRANSFERIDO,
															EMPRESA,
															BONOIP,
															BONOIS,
															FECHACSV,
															HORACSV,
															USUARIOCSV,
															VALIDADO
														)
												VALUES  (
															@RUT_PROCESADO,
															@PERIODO,
															@IMPONIBLE,
															@LIQUIDO,
															@TRANSFERIDO,
															@EMPRESA,
															@BONOIP,
															@BONOIS,
															@CURR_FECHA,
															@CURR_TIEMPOFULL,
															@USUARIO,
															'NO'
														)

											IF(@INCLU_F301 = 'SI' AND @OST <> '')
												BEGIN
													INSERT INTO A056_FORM301_LISTA
																		(
																			Empresa,
																			OST,
																			Periodo,
																			RUT
																		) 
																 VALUES (
																			@EMPRESA,
																			@OST,
																			@PERIODO,
																			@RUT_PROCESADO
																		)
												END
										END
									ELSE
										BEGIN
											SET @REPETIDO = 1
											SET @RUT_PROCESADO_ERR = @RUT_PROCESADO
											SET @PERIODO_ERR = @PERIODO
										END
								END
							ELSE
								BEGIN
									SET @RUT_INVALIDO = 1
									SET @RUT_ORIGINAL_ERR = @RUT
								END
						END
					ELSE
						BEGIN
							SET @RANGO_FECHA_INVALIDO = 1
							SET @RUT_PROCESADO_ERR = @RUT_PROCESADO
							SET @PERIODO_ERR = @PERIODO
						END
				END
			ELSE
				BEGIN
					SET @PERIODO_INVALIDO = 1
					SET @RUT_PROCESADO_ERR = @RUT_PROCESADO
					SET @PERIODO_ERR = @PERIODO
				END
		END
	ELSE
		BEGIN
			SET @RUT_PERIODO_VACIO = 1
		END
END
