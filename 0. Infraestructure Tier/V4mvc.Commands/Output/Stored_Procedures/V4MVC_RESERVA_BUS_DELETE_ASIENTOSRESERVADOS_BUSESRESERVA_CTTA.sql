CREATE PROCEDURE [dbo].[V4MVC_RESERVA_BUS_DELETE_ASIENTOSRESERVADOS_BUSESRESERVA_CTTA]
(  @IDPROG NUMERIC(18,0) = NULL
 , @RUT NVARCHAR(10) = NULL
 , @USUARIO NVARCHAR(10) = NULL) AS
BEGIN

	UPDATE RESERVA_BUS 
	SET ESTADO='NO', 
	FECHA_CANCELA = [dbo].[hoy](GETDATE()), 
	HORA_CANCELA = [dbo].[ahora](GETDATE()), 
	USUARIO_CANCELA = @USUARIO
	WHERE  (IDPROG = @IDPROG) AND (RUT = @RUT)
																			
END
