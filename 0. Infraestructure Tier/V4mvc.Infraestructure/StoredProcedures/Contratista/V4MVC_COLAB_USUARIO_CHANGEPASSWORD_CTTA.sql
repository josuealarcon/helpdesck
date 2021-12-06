CREATE PROCEDURE [dbo].[V4MVC_COLAB_USUARIO_CHANGEPASSWORD_CTTA]
(
 @IDEMPRESA		NVARCHAR(11) = NULL
,@RUT			NVARCHAR(10) = NULL
,@CLAVEACTUAL   NVARCHAR(10) = NULL
,@NUEVACLAVE	NVARCHAR(10) = NULL
)
AS
BEGIN

	DECLARE @IP NVARCHAR(15)

	IF EXISTS(
			    SELECT * FROM COLAB_USUARIO 
			    WHERE IDEMPRESA=@IDEMPRESA
			    AND RUT = @RUT
			    AND (CLAVE = @CLAVEACTUAL OR CLAVE = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@CLAVEACTUAL))), 3, 32))
			 )
	BEGIN
		IF NOT EXISTS(
						SELECT * FROM ( 
										SELECT TOP 5 CLAVE FROM COLAB_USUARIO_HST 
										WHERE RUT = @RUT 
										AND EMPRESA = @IDEMPRESA 
										ORDER BY FECHAMOD DESC
									  ) AS PASSWORDS 
						WHERE PASSWORDS.CLAVE = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@NUEVACLAVE))), 3, 32) 
					 )
		BEGIN
			UPDATE COLAB_USUARIO 
				SET CLAVE = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@NUEVACLAVE))), 3, 32)
				   ,Fecha_Modificacion = getdate()
				   ,FechaVence = convert(nvarchar(8), dateadd(m, 3, getdate()), 112)  
			WHERE IDEMPRESA = @IDEMPRESA AND RUT = @RUT

			SET @IP = (SELECT client_net_address FROM sys.dm_exec_connections WHERE session_id = @@SPID)

			INSERT INTO COLAB_USUARIO_HST 
				(
					 RUT		
					,EMPRESA	
					,CLAVE	
					,FECHAMOD	
					,HORAMOD	
					,IP
				) 
			VALUES 
				(
					 @RUT	
					,@IDEMPRESA
					,SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@NUEVACLAVE))), 3, 32)
					,dbo.hoy(getdate())
					,dbo.ahora(getdate())
					,@IP
				)
		END
	END
END

