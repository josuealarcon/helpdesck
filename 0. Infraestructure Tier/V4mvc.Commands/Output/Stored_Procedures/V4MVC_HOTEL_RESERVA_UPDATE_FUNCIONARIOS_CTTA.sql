CREATE PROCEDURE [dbo].[V4MVC_HOTEL_RESERVA_UPDATE_FUNCIONARIOS_CTTA]
(
  @RUT			    NVARCHAR(11) = ''
 ,@USUARIO		    NVARCHAR(10) = ''
 ,@IDEMPRESA		NVARCHAR(11) = ''
 ,@JSON_MAIL_DATA   NVARCHAR(4000) OUTPUT
)
AS
BEGIN
	DECLARE @ID_DOC INT = 18 /*FINIQUITO*/
	DECLARE @DIVCOD		NVARCHAR(4) = 'QV'
	DECLARE @VALIDACION	NVARCHAR(4) = ''
	DECLARE @CURR_FECHA NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 112) /* yyyymmdd */
	DECLARE @CURR_TIEMPOFULL NVARCHAR(8) = convert(NVARCHAR(8), getdate(), 108) /* hh:mm:ss */
	DECLARE @CURR_ID_RES INT
	DECLARE @FETCHED BIT
	DECLARE @SEP NVARCHAR(2)
	DECLARE @OBJ NVARCHAR(300)
	DECLARE @ACRONIMO NVARCHAR(70) = ''
	DECLARE @MAILS NVARCHAR(300) = ''
	DECLARE @MAIL NVARCHAR(40) = ''

	DECLARE @FEC_CHECKIN NVARCHAR(15) = ''
	DECLARE @HOR_CHECKIN NVARCHAR(15) = ''
	DECLARE @FEC_CHECKOUT NVARCHAR(15) = ''
	DECLARE @HOR_CHECKOUT NVARCHAR(15) = ''
	DECLARE @NOMBRE_HOTEL NVARCHAR(15) = ''
	DECLARE @PISO INT = 0
	DECLARE @NRO_PIEZA INT = 0
	DECLARE @EMPRESA NVARCHAR(70) = ''
	DECLARE @OST NVARCHAR(15) = ''
	DECLARE @NOMDIVISION NVARCHAR(70) = ''
	DECLARE @RRUT NVARCHAR(11) = ''
	DECLARE @NOMBRES NVARCHAR(70) = ''
	DECLARE @APELLIDOS NVARCHAR(70) = ''
	DECLARE @SEXO NVARCHAR(11) = ''
	DECLARE @FECHAINICIO NVARCHAR(15) = ''
	DECLARE @FECHAFIN NVARCHAR(15) = ''
	DECLARE @CHECKIN NVARCHAR(40) = ''
	DECLARE @CHECKOUT NVARCHAR(40) = ''
	

	
	IF(EXISTS(
		SELECT *
		FROM WORKERSLOCAL
		WHERE
			RUT = @RUT AND
			EMPRESA = @IDEMPRESA AND
			AUTOR <>'BL' AND
			FFINPASE >= @CURR_FECHA AND
			DIVISION = @DIVCOD
	))
		BEGIN
			SET @JSON_MAIL_DATA = '{ LISTA_RESERVAS: [ '

			IF(EXISTS(
				SELECT *
				FROM DOCS_WORKERS
				WHERE
					RUT = @RUT AND
					EMPRESA = @IDEMPRESA AND
					DIVISION = @DIVCOD AND
					VALIDADO = 'NO'
			))
				BEGIN
					INSERT INTO DOCS_WORKERS_HST
						(
						  RUT ,ID_DOC, NOMBRE_ARCHIVO, FECHA_MOD, HORA_MOD,
						  TIPO_CONTENIDO, ARCHIVO, USUARIO, CANTIDAD, GRABO,
						  CERTFECHA, CERTHORA, CERTUSUARIO, VALIDADO, EMPRESA,
						  FECHA_DEL, HORA_DEL, USUARIO_DEL, OPERACION, ID, DIVISION)
					SELECT
						RUT, ID_DOC, NOMBRE_ARCHIVO, FECHA_MOD, HORA_MOD,
						TIPO_CONTENIDO, ARCHIVO, USUARIO, CANTIDAD, GRABO,
						CERTFECHA, CERTHORA, CERTUSUARIO, VALIDADO, EMPRESA,
						@CURR_FECHA, @CURR_TIEMPOFULL, '', 'DELETE',ID,DIVISION
					FROM DOCS_WORKERS
					WHERE
						RUT = @RUT AND
						EMPRESA = @IDEMPRESA AND
						VALIDADO = 'NO' AND
						DIVISION = @DIVCOD

					DELETE
					FROM DOCS_WORKERS
					WHERE
						RUT = @RUT AND
						EMPRESA = @IDEMPRESA AND
						VALIDADO = 'NO' AND
						DIVISION = @DIVCOD
				END

			IF(EXISTS(
				SELECT *
				FROM WORKERSLOCAL
				WHERE
					RUT = @RUT AND
					EMPRESA = @IDEMPRESA AND
					DIVISION = @DIVCOD AND
					FFINPASE >= @CURR_FECHA AND
					AUTOR IN ('SI','NO')
			))
				BEGIN
					UPDATE WORKERSLOCAL
					SET
						AUTOR = 'BL',
						QUIEN = @USUARIO
					WHERE
						RUT = @RUT AND
						EMPRESA = @IDEMPRESA AND
						DIVISION = @DIVCOD AND
						FFINPASE >= @CURR_FECHA AND
						AUTOR IN ('SI','NO')
				END
			/*---------CheckOut reservas---------*/

			DECLARE getIR CURSOR FOR
			SELECT
				ID_RESERVA
			FROM HOTEL_RESERVA
			WHERE
				RUT = @RUT AND
				FECHAFIN >= @CURR_FECHA

			OPEN getIR
			FETCH NEXT
			FROM getIR INTO @CURR_ID_RES

			SET @SEP = ''

			WHILE @@FETCH_STATUS = 0
				BEGIN
					UPDATE HOTEL_RESERVA
					SET
						FECHAMOD = @CURR_FECHA,
						HORAMOD = @CURR_TIEMPOFULL,
						USRMOD = @USUARIO,
						FEC_CHECKOUT = @CURR_FECHA,
						HOR_CHECKOUT = @CURR_TIEMPOFULL,
						USR_CHECKOUT = @USUARIO
					WHERE ID_RESERVA = @CURR_ID_RES

					INSERT INTO HOTEL_RESERVA_LOG
						(
						  ID_RESERVA, ID_PIEZA, RUT, EMPRESA, FECHAINICIO,
						  FECHAFIN, FECHAREGISTRO, HORAREGISTRO, USRREGISTRO,
						  FECHAMOD, HORAMOD, USRMOD, FEC_CHECKIN, HOR_CHECKIN,
						 USR_CHECKIN, FEC_CHECKOUT, HOR_CHECKOUT, USR_CHECKOUT,
						  EST_FINRESERVA, TURNO, ENTREGALLAVE, OST, LOTE,EXCEPCION,
						  ACCION,USRENTREGA,HORAENTREGA,FECENTREGA)
					SELECT
						ID_RESERVA, ID_PIEZA, RUT, EMPRESA, FECHAINICIO, FECHAFIN,
						FECHAREGISTRO, HORAREGISTRO, USRREGISTRO, FECHAMOD, HORAMOD,
						USRMOD, FEC_CHECKIN, HOR_CHECKIN, USR_CHECKIN, FEC_CHECKOUT,
						HOR_CHECKOUT, USR_CHECKOUT, EST_FINRESERVA, TURNO, ENTREGALLAVE,
						OST, LOTE,EXCEPCION, 'CHECKOUT', USRENTREGA, HORAENTREGA, FECENTREGA
					FROM HOTEL_RESERVA
					WHERE ID_RESERVA = @CURR_ID_RES

					SET @FETCHED = 0

					SELECT 
						TOP 1
						@FEC_CHECKIN = SS.FEC_CHECKIN,
						@HOR_CHECKIN = SS.HOR_CHECKIN,
						@FEC_CHECKOUT = SS.FEC_CHECKOUT,
						@HOR_CHECKOUT = SS.HOR_CHECKOUT,
						@NOMBRE_HOTEL = SS.NOMBRE_HOTEL,
						@PISO = SS.PISO,
						@NRO_PIEZA = SS.NRO_PIEZA,
						@EMPRESA = SS.EMPRESA,
						@OST = SS.OST,
						@NOMDIVISION = SS.NOMDIVISION,
						@RRUT = SS.RUT,
						@NOMBRES = SS.NOMBRES,
						@APELLIDOS = SS.APELLIDOS,
						@SEXO = SS.SEXO,
						@FECHAINICIO = SS.FECHAINICIO,
						@FECHAFIN = SS.FECHAFIN,
						@ACRONIMO = SS.ACRONIMO,
						@FETCHED = 1
					FROM 
					(
					SELECT 
						DISTINCT HR.EMPRESA,
								 HR.OST,
								 HR.RUT,
								 W.NOMBRES,
								 W.APELLIDOS,
								 W.SEXO,
								 HR.FECHAINICIO,
								 HR.FECHAFIN,
								 H.ID_HOTEL,
								 H.NOMBRE_HOTEL,
								 HP.PISO,
								 HP.NRO_PIEZA,
								 HR.FEC_CHECKIN,
								 HR.HOR_CHECKIN,
								 HR.FEC_CHECKOUT,
								 HR.HOR_CHECKOUT,
								 ISNULL(HR.ENTREGALLAVE,'NO') AS ENTREGALLAVE,
								 L.LOCAL,
								 L.DIVISION,
								 A.DIVISION AS NOMDIVISION,
								 (
									SELECT
										TOP 1
										E.ACRONIMO
									FROM ENTERPRISE E
									WHERE E.IDEMPRESA = HR.EMPRESA
								 ) AS ACRONIMO
					FROM HOTEL_RESERVA HR
					INNER JOIN HOTEL_PIEZA HP
						ON HR.ID_PIEZA = HP.ID_PIEZA
					INNER JOIN HOTEL H
						ON H.ID_HOTEL = HP.ID_HOTEL
					INNER JOIN WORKERS W
						ON W.RUT = HR.RUT
					INNER JOIN LOCAL L
						ON H.LOCAL_HOTEL = L.LOCAL
					INNER JOIN A024_DIVISIONES A
						ON L.DIVISION = A.DIVCOD
					WHERE HR.ID_RESERVA = @CURR_ID_RES
					ORDER BY H.ID_HOTEL ASC OFFSET 0 ROWS
					) SS

					IF(@FETCHED = 1)
					BEGIN
						IF(@FEC_CHECKIN IS NOT NULL AND @FEC_CHECKIN <> '')
							BEGIN
								EXEC @FEC_CHECKIN = [dbo].[V4MVC_FGET_FEC_USER] @RAW_FEC = @FEC_CHECKIN
								SET @CHECKIN = CONCAT(@FEC_CHECKIN, ' ', @HOR_CHECKIN)
							END
						ELSE
							BEGIN
								SET @FEC_CHECKIN = ''
								SET @CHECKIN = ''
							END

						IF(@FEC_CHECKOUT IS NOT NULL AND @FEC_CHECKOUT <> '')
							BEGIN
								EXEC @FEC_CHECKOUT = [dbo].[V4MVC_FGET_FEC_USER] @RAW_FEC = @FEC_CHECKOUT
								SET @CHECKOUT = CONCAT(@FEC_CHECKOUT, ' ', @HOR_CHECKOUT)
							END
						ELSE
							BEGIN
								SET @FEC_CHECKOUT = ''
								SET @CHECKOUT = ''
							END
						/*-----JSON FORMING-----*/

						IF(@FECHAINICIO IS NOT NULL AND @FECHAINICIO <> '')
							BEGIN
								EXEC @FECHAINICIO = [dbo].[V4MVC_FGET_FEC_USER] @RAW_FEC = @FECHAINICIO
							END
						ELSE
							BEGIN
								SET @FECHAINICIO = ''
							END

						IF(@FECHAFIN IS NOT NULL AND @FECHAFIN <> '')
							BEGIN
								EXEC @FECHAFIN = [dbo].[V4MVC_FGET_FEC_USER] @RAW_FEC = @FECHAFIN
							END
						ELSE
							BEGIN
								SET @FECHAFIN = ''
							END

						EXEC @EMPRESA = [dbo].[V4MVC_FSTR_RUT] @RAW_RUT = @EMPRESA

						SET @OBJ = CONCAT('{FEC_CHECKIN:''', @FEC_CHECKIN, ''', HOR_CHECKIN:''', @HOR_CHECKIN, ''', FEC_CHECKOUT:''', @FEC_CHECKOUT, ''', HOR_CHECKOUT:''', @HOR_CHECKOUT)
						SET @OBJ = CONCAT(@OBJ, ''', NOMBRE_HOTEL:''', @NOMBRE_HOTEL, ''', PISO:', CONVERT(NVARCHAR, @PISO), ', NRO_PIEZA:', CONVERT(NVARCHAR, @NRO_PIEZA), ', EMPRESA:''', @EMPRESA)
						SET @OBJ = CONCAT(@OBJ, ''', OST:''', @OST, ''', NOMDIVISION:''', @NOMDIVISION, ''', RUT:''', @RRUT, ''', NOMBRES:''', @NOMBRES, ''', APELLIDOS:''', @APELLIDOS)
						SET @OBJ = CONCAT(@OBJ, ''', SEXO:''', @SEXO, ''', FECHAINICIO:''', @FECHAINICIO, ''', FECHAFIN:''', @FECHAFIN, ''', ACRONIMO:''', @ACRONIMO, ''', CHECKIN:''', @CHECKIN, ''', CHECKOUT:''', @CHECKOUT, '''}')
						SET @JSON_MAIL_DATA = CONCAT(@JSON_MAIL_DATA, @SEP, @OBJ)

					END
					 
					SET @SEP = ','
					FETCH NEXT
					FROM getIR INTO @CURR_ID_RES

				END
			
			CLOSE getIR
			DEALLOCATE getIR

			/*MAS SOBRE EMAILS*/

			SET @SEP = ''
			SELECT
				TOP 1
				@MAIL = ISNULL(EMAILHOTEL,'')
			FROM ENTERPRISE
			WHERE IDEMPRESA = @IDEMPRESA
			
			IF(@MAIL <> '')
				BEGIN
					SET @MAILS = CONCAT('''', @MAIL, '''')
					SET @SEP = ','
				END
			
			SET @MAIL = ''

			SELECT
				TOP 1
				@MAIL = ISNULL(CORREO_ELECTRONICO,'')
			FROM COLAB_USUARIO
			WHERE IDEMPRESA = @IDEMPRESA

			IF(@MAIL <> '')
				BEGIN
					SET @MAILS = CONCAT(@MAILS, @SEP, '''', @MAIL , '''')
					SET @SEP = ','
				END
			
			SET @MAIL = ''

			SELECT
				TOP 1
				@MAIL = ISNULL(EMAIL,'')
			FROM DESTINATARIOS
			WHERE MODULO = 'ALERTA_ADMIN_HOTELERO'

			IF(@MAIL <> '')
				BEGIN
					SET @MAILS = CONCAT(@MAILS, @SEP, '''', @MAIL , '''')
					SET @SEP = ','
				END
			
			SELECT
				TOP 1
				@NOMBRES = CONCAT(NOMBRES, ' ', APELLIDOS)
			FROM WORKERS
			WHERE RUT = @RUT

			SET @JSON_MAIL_DATA = CONCAT(@JSON_MAIL_DATA, '], EMAILS: [', @MAILS, '] , NOMBRE_DE_RUT: ''', @NOMBRES, '''}')

			UPDATE WORKERS
			SET
				EMPRESA = '999999999'
			WHERE RUT = @RUT
		END
END
