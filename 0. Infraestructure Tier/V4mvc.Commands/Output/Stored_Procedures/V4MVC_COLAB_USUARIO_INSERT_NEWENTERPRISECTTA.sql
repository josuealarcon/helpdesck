CREATE PROCEDURE [dbo].[V4MVC_COLAB_USUARIO_INSERT_NEWENTERPRISECTTA]
(
 @IDEMPRESA NVARCHAR(10)
,@RUT NVARCHAR(10)
,@CLAVE NVARCHAR(50)
,@CORREO_ELECTRONICO NVARCHAR(100)
)
AS
BEGIN

	INSERT INTO [COLAB_USUARIO]
	(
		 IdEmpresa			,Rut		,Clave			,Correo_Electronico		
		,TipoUsuario		,Activo		,EnvioAlertas	,Fecha_Creacion
		,Fecha_Modificacion
	)
	VALUES
	(
		 @IDEMPRESA			,@RUT		,@CLAVE			,@CORREO_ELECTRONICO
		,'ADMIN'			,'SI'			,'SI'			,DBO.HOY(GETDATE())
		,DBO.HOY(GETDATE())
	)
END
