CREATE PROCEDURE [dbo].[V4MVC_UPDATE_COLABUSUARIO_CAMBIOCLAVE]  
( @IDEMPRESA NVARCHAR(10) 
, @RUT NVARCHAR(10)
, @NEWPASSWORD NVARCHAR(10)  
)  
AS  
BEGIN  
  
	UPDATE COLAB_USUARIO   
	SET Clave = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@NEWPASSWORD))), 3, 32)
		, FechaVence			= DBO.HOY(GETDATE())
		, Fecha_Modificacion	= DBO.HOY(GETDATE())
	WHERE idempresa	= @IDEMPRESA 
      and rut		= @RUT
  
END
