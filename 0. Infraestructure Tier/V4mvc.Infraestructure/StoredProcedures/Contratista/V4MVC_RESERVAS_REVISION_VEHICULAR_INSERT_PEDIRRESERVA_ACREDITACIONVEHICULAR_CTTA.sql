CREATE PROCEDURE [dbo].[V4MVC_RESERVAS_REVISION_VEHICULAR_INSERT_PEDIRRESERVA_ACREDITACIONVEHICULAR_CTTA]
(
  @EMPRESA				NVARCHAR(10) = NULL
 ,@PATENTE				NVARCHAR(8) = NULL
 ,@FECHARES				NVARCHAR(8) = NULL
 ,@HORAINICIO			NVARCHAR(8) = NULL
 ,@HORATERMINO			NVARCHAR(8) = NULL
 ,@MINUTOS				INT = NULL
 ,@USUARIOSOL			NVARCHAR(10) = NULL
 ,@DIVISION				NVARCHAR(10) = NULL
 ,@OST					NVARCHAR(20) = NULL
 ,@IDMOTIVORESERVA		INT = NULL
 ,@EXITOSO				BIT  OUTPUT
 ,@SALIDA				INT OUTPUT
) AS
BEGIN

	SET @SALIDA = 0
	IF NOT EXISTS(
			SELECT *
			FROM RESERVAS_REVISION_VEHICULAR
			WHERE
				EMPRESA = @EMPRESA AND
				PATENTE = @PATENTE AND
				ASISTIO = 'NO' AND
				MOTIVO IS NULL AND
				(
					FECHARES > CONVERT(NVARCHAR(8),GETDATE(),112) OR
					(FECHARES = CONVERT(NVARCHAR(8),GETDATE(),112) AND
					HORATERMINO > [dbo].[ahora](GETDATE()))
				)
			)
	BEGIN

			INSERT INTO RESERVAS_REVISION_VEHICULAR(EMPRESA					, PATENTE					, FECHARES					, HORAINICIO, 
													HORATERMINO				, MINUTOS					, FECHASOL					, HORASOL, 
													FECHAMOD				, HORAMOD					, USUARIOSOL				, DIVISION, 
													OST						, IDMOTIVORESERVA) 
											VALUES (@EMPRESA				, @PATENTE					, @FECHARES					, @HORAINICIO, 
													@HORATERMINO			,30							, [dbo].[hoy](GETDATE())	, [dbo].[ahora](GETDATE()), 
													[dbo].[hoy](GETDATE())	,[dbo].[ahora](GETDATE())	, @USUARIOSOL				,@DIVISION, 
													@OST					,@IDMOTIVORESERVA)

			SET @EXITOSO = 1																													

	END
	ELSE
	BEGIN

			 SET @EXITOSO = 0
			 SET @SALIDA = 1  --'La Reserva no puede ser realizada.  El vehículo con patente P ya posee una reserva Vigente  para el día X.Podría cancelar la reserva y hacer una nueva solamente con 48 hrs. de anticipación.'

	END

END


