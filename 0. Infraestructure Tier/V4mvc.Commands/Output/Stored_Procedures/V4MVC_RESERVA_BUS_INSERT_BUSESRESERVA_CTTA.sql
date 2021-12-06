CREATE PROCEDURE [dbo].[V4MVC_RESERVA_BUS_INSERT_BUSESRESERVA_CTTA]
( @IDPROG		NUMERIC(18,0) = NULL
, @RUT			NVARCHAR(10) = NULL
, @EMPRESA		NVARCHAR(10) = NULL
, @OST			NVARCHAR(10) = NULL
, @USUARIO		NVARCHAR(10) = NULL
) AS
BEGIN
	DECLARE  
	 @Rs_DisponibleDISPONIBLES		INT
	,@Rs_DisponibleBUSDIRORI		NVARCHAR(50)
	,@Rs_DisponibleBUSDIRDES		NVARCHAR(50)
	,@Rs_DisponibleFECHA			NVARCHAR(8)
	,@Rs_DisponibleDIRECCION		NVARCHAR(10)
	,@Rs_DisponibleORIGEN			NVARCHAR(20)
	,@Rs_DisponibleHORA				NVARCHAR(8)
	,@Rs_DisponibleDIVISION			NVARCHAR(4)
	,@SubidaPerez					BIT
	,@Cantidad_Viajes				INT
	,@ControlPerez					NVARCHAR(2)
	,@NOMBRES						NVARCHAR(100)
	,@APELLIDOS						NVARCHAR(100)	

	CREATE TABLE #RESULTADOS 
	(EXITOSO		INT
	,MENSAJE		NVARCHAR(MAX)
	,RUT			NVARCHAR(20)
	,NOMBRES		NVARCHAR(100)
	,APELLIDOS		NVARCHAR(100)
	,ORIGEN			NVARCHAR(100)
	,DESTINO		NVARCHAR(100)
	,FECHA			NVARCHAR(100))

	SELECT TOP 1 @Rs_DisponibleDISPONIBLES=DISPONIBLES			,@Rs_DisponibleFECHA=FECHA			,@Rs_DisponibleHORA= HORA				,@Rs_DisponibleBUSDIRORI=BUSDIRORI
			,@Rs_DisponibleBUSDIRDES=BUSDIRDES				,@Rs_DisponibleDIRECCION=DIRECCION	,@Rs_DisponibleORIGEN=ORIGEN			,@Rs_DisponibleDIVISION=DIVISION 
			FROM A203_BUS_PAS WHERE (IDPROG = @IDPROG)
	
	SELECT TOP 1 @NOMBRES= NOMBRES ,@APELLIDOS= APELLIDOS FROM WORKERS WHERE RUT = @RUT

	IF(@Rs_DisponibleDISPONIBLES>=1)
		BEGIN
			--PRINT'VALIDACION 1'
			IF EXISTS (SELECT CONTROL_PEREZ, ISNULL(CANTIDAD_SUBIDAS,1) AS CANTIDAD_SUBIDAS, ISNULL(CANTIDAD_BAJADAS,1) AS CANTIDAD_BAJADAS FROM VIAJES_PARAMETROS) 
				BEGIN
		
					DECLARE  @Rs_ParametrosCONTROL_PEREZ		NVARCHAR(2)
							,@Rs_ParametrosCANTIDAD_SUBIDAS		INT
							,@Rs_ParametrosCANTIDAD_BAJADAS		INT

					SELECT @Rs_ParametrosCONTROL_PEREZ=CONTROL_PEREZ			,@Rs_ParametrosCANTIDAD_SUBIDAS= ISNULL(CANTIDAD_SUBIDAS,1)			,@Rs_ParametrosCANTIDAD_BAJADAS= ISNULL(CANTIDAD_BAJADAS,1) 
					FROM VIAJES_PARAMETROS

					SET @ControlPerez = @Rs_ParametrosCONTROL_PEREZ
					IF @Rs_DisponibleDIRECCION= 'SUBIDA'
						BEGIN
							SET @Cantidad_Viajes = @Rs_ParametrosCANTIDAD_SUBIDAS
						END
						ELSE IF @Rs_DisponibleDIRECCION='BAJADA'
						BEGIN
							SET @Cantidad_Viajes = @Rs_ParametrosCANTIDAD_BAJADAS
						END
				END
			ELSE
				BEGIN
					SET @ControlPerez = 'SI'
					SET @Cantidad_Viajes = 1
				END		
			
			If @ControlPerez = 'SI' 
				BEGIN
					If @Rs_DisponibleORIGEN = 'PEREZ_CALDERA' 
						BEGIN
							IF EXISTS (	SELECT TOP 1 P.DESTINO FROM RESERVA_BUS R 
										INNER JOIN PROGBUS P ON P.IDPROG = R.IDPROG 
										WHERE R.RUT = @RUT AND R.ESTADO = 'SI' 
										AND DATEDIFF(day, P.FECHA, @Rs_DisponibleFECHA) <= 15 
										AND P.FECHA <= @Rs_DisponibleFECHA 
										ORDER BY P.FECHA DESC)
							BEGIN
							    DECLARE @Rs_DestinoPerezDESTINO		NVARCHAR(20)

							    SELECT TOP 1 @Rs_DestinoPerezDESTINO=P.DESTINO 
								FROM RESERVA_BUS R 
								INNER JOIN PROGBUS P ON P.IDPROG = R.IDPROG 
								WHERE R.RUT = @RUT AND R.ESTADO = 'SI' 
								AND DATEDIFF(day, P.FECHA, @Rs_DisponibleFECHA) <= 15 
								AND P.FECHA <= @Rs_DisponibleFECHA 
								ORDER BY P.FECHA DESC
								If @Rs_DestinoPerezDESTINO = 'PEREZ_CALDERA' 
								BEGIN
									 SET @SubidaPerez = 1
						        END
								ELSE
								BEGIN									
									 SET @SubidaPerez = 0
								END
							END
							ELSE
							BEGIN
								 SET @SubidaPerez = 0
							END
						END
					ELSE
						BEGIN
						 SET @SubidaPerez = 1
						END
				END
			ELSE
				BEGIN
					SET @SubidaPerez = 1
				END		
			
			IF(@SubidaPerez=1)
				BEGIN
					--PRINT'VALIDACION 2'
					DECLARE @Rs_HoraHORA NVARCHAR(8)
							,@Rs_HoraHORAFIN NVARCHAR(8)
							,@Rs_HoraFECHA NVARCHAR(8)
							,@CANTIDAD_RESERVAS INT = 0
					
					SELECT @Rs_HoraHORA=HORA		,@Rs_HoraHORAFIN=CONVERT(VARCHAR(8)		,DATEADD(HH, CONVERT(INT, DURACION), HORA), 8)		,@Rs_HoraFECHA=FECHA 
					FROM PROGBUS WHERE FECHA >= GETDATE() AND IDPROG = @IDPROG

					SELECT @CANTIDAD_RESERVAS= COUNT(RUT)
					FROM RESERVA_BUS R 
					INNER JOIN PROGBUS P ON P.IDPROG = R.IDPROG 
					WHERE P.FECHA = @Rs_DisponibleFECHA 
					AND R.RUT = @RUT 
					AND P.DIRECCION = @Rs_DisponibleDIRECCION 
					AND R.ESTADO = 'SI'

					IF(@CANTIDAD_RESERVAS<@Cantidad_Viajes)
						BEGIN
							--PRINT'VALIDACION 3'
							IF NOT EXISTS (SELECT RUT FROM RESERVA_BUS R 
										   INNER JOIN PROGBUS P ON P.IDPROG = R.IDPROG 
										   WHERE P.FECHA = @Rs_DisponibleFECHA 
										   AND P.HORA = @Rs_DisponibleHORA 
										   AND R.RUT = @RUT AND ESTADO='SI')
								BEGIN
									--PRINT'VALIDACION 4'
									DECLARE @Rs_ViajeBUSDIRORI		NVARCHAR(50)
											,@Rs_ViajeBUSDIRDES		NVARCHAR(50)
											,@Rs_ViajeFECHA			NVARCHAR(8)
											,@Rs_ViajeHORA			NVARCHAR(8)
											,@Rs_ViajeDURACION		NVARCHAR(2)
											
									SELECT @Rs_ViajeFECHA= p.FECHA		,@Rs_ViajeHORA=p.HORA		,@Rs_ViajeDURACION=p.DURACION		,@Rs_ViajeBUSDIRORI=O.BUSDIRORI		,@Rs_ViajeBUSDIRDES=D.BUSDIRDES 
									FROM RESERVA_BUS r 
									INNER JOIN PROGBUS p ON r.IDPROG = p.IDPROG 
									INNER JOIN BUSORIGEN O ON O.BUSORIGEN = P.ORIGEN 
									INNER JOIN BUSDESTINO D ON D.BUSDESTINO = P.DESTINO 
									WHERE P.FECHA >= GETDATE() 
									AND R.RUT=@RUT 
									AND CONVERT(VARCHAR(8),DATEADD(HH,CONVERT(INT,P.DURACION),P.HORA),8) >@Rs_HoraHORA 
									AND CONVERT(VARCHAR(8),P.HORA,8) < @Rs_HoraHORAFIN 
									AND P.FECHA = @Rs_HoraFECHA 
									AND R.ESTADO='SI'
									
									IF NOT EXISTS (SELECT p.ORIGEN, p.DESTINO, p.FECHA, p.HORA, p.DURACION, O.BUSDIRORI, D.BUSDIRDES 
										FROM RESERVA_BUS r 
										INNER JOIN PROGBUS p ON r.IDPROG = p.IDPROG 
										INNER JOIN BUSORIGEN O ON O.BUSORIGEN = P.ORIGEN 
										INNER JOIN BUSDESTINO D ON D.BUSDESTINO = P.DESTINO 
										WHERE P.FECHA >= GETDATE() 
										AND R.RUT=@RUT 
										AND CONVERT(VARCHAR(8),DATEADD(HH,CONVERT(INT,P.DURACION),P.HORA),8) >@Rs_HoraHORA 
										AND CONVERT(VARCHAR(8),P.HORA,8) < @Rs_HoraHORAFIN 
										AND P.FECHA = @Rs_HoraFECHA 
										AND R.ESTADO='SI')--VALIDACION 5
										BEGIN
											--PRINT'VALIDACION 5'
											IF EXISTS (SELECT TOP 1 FINIPASE, FFINPASE, VALIDADO, AUTOR, TIPOPASE, EMPRESA, OST 
											FROM WORKERSLOCAL 
											WHERE RUT=@RUT 
											AND DIVISION=@Rs_DisponibleDIVISION  
											AND EMPRESA = @EMPRESA 
											AND AUTOR='SI' 
											AND VALIDADO='SI' 
											AND @Rs_DisponibleFECHA BETWEEN FINIPASE AND FFINPASE 
											ORDER BY LOTE DESC)
											BEGIN
												--PRINT'VALIDACION 6'
												DECLARE @Rs_DatosAUTOR			NVARCHAR(2)
												,@Rs_DatosVALIDADO				NVARCHAR(2)
												,@Rs_DatosEMPRESAW				NVARCHAR(10)
												,@Rs_DatosOSTW					NVARCHAR(14)
												,@Rs_DatosTIPOPASE				NVARCHAR(9)
												,@Rs_DatosFINIPASE				NVARCHAR(8)
												,@Rs_DatosFFINPASE				NVARCHAR(8)
												,@Rs_CantReservaCANTRESERVAS	INT = 0
												,@Rs_CuotaOSTCUOTATRANS			INT = 0
												,@DISPONE_CUOTA					BIT

												SELECT TOP 1 @Rs_DatosAUTOR=AUTOR		,@Rs_DatosVALIDADO=VALIDADO		,@Rs_DatosFINIPASE=FINIPASE		,@Rs_DatosFFINPASE=FFINPASE
													,@Rs_DatosTIPOPASE= TIPOPASE,@Rs_DatosEMPRESAW= EMPRESA		,@Rs_DatosOSTW=OST 
												FROM WORKERSLOCAL 
												WHERE RUT=@RUT 
												AND DIVISION=@Rs_DisponibleDIVISION  
												AND EMPRESA = @EMPRESA 
												AND AUTOR='SI' 
												AND VALIDADO='SI' 
												AND @Rs_DisponibleFECHA BETWEEN FINIPASE AND FFINPASE 
												ORDER BY LOTE DESC	
													
												SELECT @Rs_CantReservaCANTRESERVAS=ISNULL(SUM(CANTIDAD), 0) 
												FROM WC3_VISTA_RESERVA_BUS_SI 
												WHERE OST = @Rs_DatosOSTW 
												AND EMPRESA = @Rs_DatosEMPRESAW 
												AND SUBSTRING(FECHA, 1,6) = SUBSTRING(@Rs_HoraFECHA, 1,6)
											
												SELECT @Rs_CuotaOSTCUOTATRANS=CUOTATRANS 
												FROM OST_TRANSPORTE_CUOTA 
												WHERE OST = @Rs_DatosOSTW 
												AND EMPRESA = @Rs_DatosEMPRESAW											

												If EXISTS(SELECT CUOTATRANS FROM OST_TRANSPORTE_CUOTA WHERE OST = @Rs_DatosOSTW AND EMPRESA = @Rs_DatosEMPRESAW) 
													BEGIN
														If @Rs_CantReservaCANTRESERVAS >= @Rs_CuotaOSTCUOTATRANS 
															BEGIN
																SET @DISPONE_CUOTA = 0
															END
														ELSE
															BEGIN
																SET @DISPONE_CUOTA = 1
														END
													END
												ELSE
													BEGIN
														SET @DISPONE_CUOTA = 1
													END

												IF @DISPONE_CUOTA = 1 --VALIDACION 7
													BEGIN
														--PRINT'VALIDACION 7'
														DECLARE @Rs_EstadoAlertaESTADO	NVARCHAR(10)
														,@ESTADO					BIT

														SELECT @Rs_EstadoAlertaESTADO=ESTADO 
														FROM ALERTA_FAENA 
														WHERE DIVISION = @Rs_DisponibleDIVISION
														If EXISTS(SELECT ESTADO FROM ALERTA_FAENA WHERE DIVISION = @Rs_DisponibleDIVISION)
															BEGIN
																IF @Rs_EstadoAlertaESTADO = 'ROJA'
																	BEGIN
																		SET @ESTADO = 0
																	END
																ELSE
																	BEGIN
																		IF @Rs_DatosTIPOPASE = 'VISITA' And @Rs_EstadoAlertaESTADO = 'AMARILLA' 
																			BEGIN
																				SET @ESTADO = 0
																			END
																		ELSE
																			BEGIN
																				SET @ESTADO = 1
																			END
																	END
															END
														ELSE
															BEGIN
																SET @ESTADO = 1
															END
														
														IF @ESTADO = 1 --VALIDACION 8
														BEGIN
															--PRINT'VALIDACION 8'
															DECLARE @Rs_DocsID_DOC_FEC INT 

															SELECT DISTINCT  DF.ID_DOC_FEC,ROW_NUMBER() OVER(ORDER BY DF.ID_DOC_FEC ASC) AS ID
															INTO #TIPOS_PASE
															FROM DOCS_TIPOPASE DT 
															INNER JOIN DOCS D ON D.ID_DOC = DT.ID_DOC 
															INNER JOIN DOCS_FEC DF ON DF.ID_DOC_DEPEND = D.ID_DOC 
															INNER JOIN DOCS_FEC_TIPOPASE DFT ON DFT.ID_DOC_FEC = DF.ID_DOC_FEC 
															WHERE D.ACTIVO = 'SI' AND DF.ACTIVO = 'SI' 
															AND DT.TIPOPASE = @Rs_DatosTIPOPASE
															AND DT.DIVISION = @Rs_DisponibleDIVISION
															AND DF.VALIDO_MAYOR_HOY = 1 AND D.ID_TIPO_PROPIETARIO = 1 
															AND D.ID_DOC_OPCION = 0 
															AND DFT.TIPOPASE = @Rs_DatosTIPOPASE
															AND DFT.DIVISION = @Rs_DisponibleDIVISION

															DECLARE @CONTADOR_PASES					INT = 1
															DECLARE @MAXIMO_PASES					INT
															DECLARE @VALIDACION_FECHA_CORRECTA		INT = 0
															DECLARE @FECHA_FUNCION					NVARCHAR(8)

															SELECT @MAXIMO_PASES = MAX(ID) FROM #TIPOS_PASE

															WHILE  (@MAXIMO_PASES<= @CONTADOR_PASES)
																BEGIN
																	DECLARE  @ID_DOC_FE_WHILE INT 
																	SELECT @ID_DOC_FE_WHILE=  ID_DOC_FEC FROM #TIPOS_PASE
																	WHERE ID = @CONTADOR_PASES
																
																	SELECT @FECHA_FUNCION = dbo.[V4MVC_FN_GET_FECHA_VEHICULO_BUSESRESERVA](@ID_DOC_FE_WHILE,@RUT,@Rs_DisponibleDIVISION,@EMPRESA)
																	
																	IF @FECHA_FUNCION < @Rs_DisponibleFECHA 
																		SET @VALIDACION_FECHA_CORRECTA = 1
                                                                    SET @CONTADOR_PASES = @CONTADOR_PASES + 1
																END
															IF @Rs_DatosFINIPASE <= @Rs_DisponibleFECHA AND @Rs_DatosFFINPASE >= @Rs_DisponibleFECHA --VALIDACION 9
																BEGIN									                                                           
																	--PRINT'VALIDACION 9'
																	IF (@Rs_DatosAUTOR = 'SI' And @Rs_DatosVALIDADO = 'SI' AND @VALIDACION_FECHA_CORRECTA = 0)
																		BEGIN
																			--PRINT'VALIDACION 10'
																			IF  EXISTS (SELECT RUT FROM RESERVA_BUS WHERE (IDPROG = @IDPROG) AND (RUT = @RUT)) 
																				BEGIN
																					UPDATE RESERVA_BUS 
																					SET ESTADO = 'SI', 
																					FECHA_RESERVA = [dbo].[hoy](GETDATE()),
																					HORA_RESERVA = [dbo].[ahora](GETDATE())
																					WHERE (IDPROG = @IDPROG) AND (RUT = @RUT)

																					INSERT INTO #RESULTADOS
																					(EXITOSO		,MENSAJE		,RUT			,NOMBRES
																					 ,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
																					 VALUES(
																					 1		,'EXITOSO'   ,@RUT		,@NOMBRES
																					 ,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
																				END
																			ELSE
																				BEGIN
																					INSERT INTO RESERVA_BUS(IDPROG		,RUT		,EMPRESA		,OST	,UTILIZO
																											,USUARIO	,ESTADO		,FECHA_RESERVA	,HORA_RESERVA) 
																					VALUES  (@IDPROG		,@RUT		,@EMPRESA				,@OST						,'NO'  
																							,@USUARIO		,'SI'		,[dbo].[hoy](GETDATE())	,[dbo].[ahora](GETDATE()));

																					INSERT INTO #RESULTADOS
																						(EXITOSO		,MENSAJE		,RUT			,NOMBRES
																					 ,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
																					 VALUES(
																					 1		,'EXITOSO'   ,@RUT		,@NOMBRES
																					 ,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)	
																				END
																		END
																	ELSE
																		BEGIN
																			INSERT INTO #RESULTADOS
																			(EXITOSO		,MENSAJE		,RUT			,NOMBRES
																			 ,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
																			 VALUES(
																			 '0'		,'Funcionarios que no se Encuentran Acreditados'   ,@RUT		,@NOMBRES
																			 ,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
																		END
																END
															ELSE
																BEGIN
																	INSERT INTO #RESULTADOS
																	(EXITOSO		,MENSAJE		,RUT			,NOMBRES
																	 ,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
																	 VALUES(
																	 '0'		,'Funcionarios con Pase Vencido.'   ,@RUT						,@NOMBRES
																	 ,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
																END

														END
														ELSE --VALIDACION 8
															BEGIN
																INSERT INTO #RESULTADOS
																(EXITOSO		,MENSAJE		,RUT			,NOMBRES
																,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
																VALUES(
																'0'		,'Funcionarios que no pueden reservar por alerta en faena'   ,@RUT						,@NOMBRES
																,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
															END
													END
														ELSE --VALIDACION 7
															BEGIN
																INSERT INTO #RESULTADOS
																(EXITOSO		,MENSAJE		,RUT			,NOMBRES
																,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
																VALUES(
																'0'		,'Funcionarios que no pueden reservar por superar cuota mensual por Contrato'   ,@RUT						,@NOMBRES
																,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
															END
					 							END
					 						ELSE --VALIDACION 6
					 							BEGIN
													INSERT INTO #RESULTADOS
													(EXITOSO		,MENSAJE		,RUT			,NOMBRES
													,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
													VALUES(
													'0'		,'Funcionarios que no se Encuentran Acreditados'   ,@RUT						,@NOMBRES
													,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
												END
					 
					 					END
									ELSE
					 					BEGIN
											INSERT INTO #RESULTADOS
											(EXITOSO		,MENSAJE		,RUT			,NOMBRES
											,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
											VALUES(
											'0'		,'Funcionarios que ya cuentan con una reserva dentro del horario del viaje'   ,@RUT						,@NOMBRES
											,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
											--SET @EXITOSO = 0
											--SET @MENSAJE = 'Funcionarios que ya cuentan con una reserva dentro del horario del viaje.'
											--SET @TABLA = N'<Table width="100%" class="table table-striped table-hover">'
											--SET @TABLA = @TABLA + N'<Tr><Td colspan = "5" align="center" class="Msg"><strong>Funcionarios que ya cuentan con una reserva dentro del horario del viaje</strong></Td></Tr>'
											--SET @TABLA = @TABLA + N'<tr><td class="Titulo">RUT</td><td class="Titulo">Nombres</td>'
											--SET @TABLA = @TABLA + N'<td class="Titulo">Origen</td><td class="Titulo">Destino</td><td class="Titulo">Fecha</td></tr>'
											--SET @TABLA = @TABLA + N'<Tr><Td class="Contenido">' + @RUT + '</Td>' 
											--SET @TABLA = @TABLA + N'<Td class="Contenido">' + (SELECT TOP 1 NOMBRES + ' ' + APELLIDOS FROM WORKERS WHERE RUT = @RUT) + '</Td>'
											--SET @TABLA = @TABLA + N'<td class="Contenido">' + @Rs_DisponibleBUSDIRORI + '</td>'
											--SET @TABLA = @TABLA + N'<td class="Contenido">' + @Rs_DisponibleBUSDIRDES + '</td>'
											--SET @TABLA = @TABLA + N'<td class="Contenido">' + CONVERT(varchar,CONVERT (datetime, @Rs_DisponibleFECHA),106) + '</td></Tr>'
											--SET @TABLA = @TABLA + N'<tr><td class="Titulo" colspan=""5"" align="center"><strong>Viaje que no permite la reserva</strong></td></tr>'
											--SET @TABLA = @TABLA + N'<tr><td class="Titulo">Origen</td><td class=""Titulo"">Destino</td>'
											--SET @TABLA = @TABLA + N'<td class="Titulo">Fecha</td><td class="Titulo">Hora</td>'
											--SET @TABLA = @TABLA + N'<td class="Titulo">Duraci&oacute;n</td></tr>'
											--SET @TABLA = @TABLA + N'<tr><td class="Contenido">' + @Rs_ViajeBUSDIRORI + '</td>'
											--SET @TABLA = @TABLA + N'<td class="Contenido">' + @Rs_ViajeBUSDIRDES + '</td>'
											--SET @TABLA = @TABLA + N'<td class="Contenido">' + CONVERT(varchar,CONVERT (datetime, @Rs_ViajeFECHA),106)  + '</td>'
											--SET @TABLA = @TABLA + N'<td class="Contenido">' + @Rs_ViajeHORA + '</td>'
											--SET @TABLA = @TABLA + N'<td class="Contenido">' + ISNULL(@Rs_ViajeDURACION,'Hrs') + ' </td></Tr>'
											--SET @TABLA = @TABLA + N'</Table>'
										END
								END
							ELSE
								BEGIN
									INSERT INTO #RESULTADOS
									(EXITOSO		,MENSAJE		,RUT			,NOMBRES
									,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
									VALUES(
									'0'		,'Funcionarios que ya cuentan con una reserva en este horario'   ,@RUT						,@NOMBRES
									,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
								END
						END
					ELSE
						BEGIN
							INSERT INTO #RESULTADOS
							(EXITOSO		,MENSAJE		,RUT			,NOMBRES
							,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
							VALUES(
							'0'		,'Funcionarios que no pueden reservar por contar con reserva en misma direcci&oacute;n para el d&iacute;a seleccionado.'   ,@RUT						,@NOMBRES
							,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
						END
				END
			ELSE
				BEGIN
					INSERT INTO #RESULTADOS
					(EXITOSO		,MENSAJE		,RUT			,NOMBRES
					,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
					VALUES(
					'0'		,'Funcionarios que no cuentan con reserva anterior de subida a PEREZ CALDERA.'   ,@RUT						,@NOMBRES
					,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
				END
		
		END
	ELSE
		BEGIN
			INSERT INTO #RESULTADOS
			(EXITOSO		,MENSAJE		,RUT			,NOMBRES
			,APELLIDOS		,ORIGEN			,DESTINO		,FECHA)
			VALUES(
			'0'		,'Funcionarios que quedaron sin Reservas por superar limite de capacidad.'   ,@RUT						,@NOMBRES
			,@APELLIDOS,@Rs_DisponibleBUSDIRORI			,@Rs_DisponibleBUSDIRDES	,@Rs_DisponibleFECHA)
		END
	SELECT * FROM #RESULTADOS
END
