CREATE PROCEDURE [dbo].[V4MVC_COLAB_USUARIO_ENTERPRISE_SELECT]
(
@IDEMPRESA NVARCHAR(10)
)
AS
BEGIN

	SELECT DISTINCT
		CU.Rut,
		CU.Correo_Electronico,
		W.NOMBRES,
		W.APELLIDOS,
		CU.TipoUsuario,
		CU.Activo
	FROM COLAB_USUARIO CU
	INNER JOIN WORKERS AS W
		ON CU.RUT = W.RUT 
	WHERE IDEMPRESA = @IDEMPRESA
	ORDER BY CU.Rut DESC
END
