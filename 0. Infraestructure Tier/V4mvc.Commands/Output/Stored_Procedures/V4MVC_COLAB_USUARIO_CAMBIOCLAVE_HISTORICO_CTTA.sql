CREATE PROCEDURE [dbo].[V4MVC_COLAB_USUARIO_CAMBIOCLAVE_HISTORICO_CTTA]
(
 @ID				NVARCHAR(10)
,@IDEMPRESA			NVARCHAR(11)
,@NUEVACLAVE		NVARCHAR(20)
,@IP				NVARCHAR(50)
)
AS
BEGIN

	INSERT INTO COLAB_USUARIO_HST (
									 RUT		
									,EMPRESA	
									,CLAVE	
									,FECHAMOD	
									,HORAMOD	
									,IP			) 
	VALUES						(
									 @ID	
									,@IDEMPRESA
									,SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@NUEVACLAVE))), 3, 32)
									,dbo.hoy(getdate())
									,dbo.ahora(getdate())
									,@IP
								)

END
