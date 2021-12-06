CREATE PROCEDURE [dbo].[V4MVC_COLAB_USUARIO_CAMBIOCLAVE_CTTA]
(
 @ID				NVARCHAR(10)
,@IDEMPRESA			NVARCHAR(10)
,@NUEVACLAVE		NVARCHAR(20)
)
AS
BEGIN

	UPDATE COLAB_USUARIO 
	SET  CLAVE = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@NUEVACLAVE))), 3, 32)
		,Fecha_Modificacion = DBO.HOY(GETDATE())
		,FechaVence = convert(nvarchar(8), dateadd(m, 3, getdate()), 112)  
	WHERE IDEMPRESA = @IDEMPRESA 
	AND RUT = @ID

END
