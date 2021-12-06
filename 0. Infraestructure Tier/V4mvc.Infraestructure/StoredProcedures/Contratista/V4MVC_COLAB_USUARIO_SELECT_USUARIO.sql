CREATE PROCEDURE [dbo].[V4MVC_COLAB_USUARIO_SELECT_USUARIO]  
( @IdEmpresa           NVARCHAR(10) = NULL  
, @Rut                 nvarchar(10) = NULL) AS  
BEGIN  
  
	SELECT CU.IdEmpresa          ,CU.Rut           ,CU.Clave        ,CU.Correo_Electronico  
		  ,CU.TipoUsuario        ,CU.Activo        ,CU.EnvioAlertas ,CU.Fecha_Creacion      
          ,CU.Fecha_Modificacion ,CU.Ultimo_Acceso ,CU.FechaVence   ,W.NOMBRES
		  ,W.APELLIDOS			 ,E.IDEMPRESA	   ,E.ACRONIMO		,E.NOMBRE
	FROM COLAB_USUARIO CU
	INNER JOIN WORKERS W ON CU.Rut = W.RUT
	INNER JOIN ENTERPRISE E ON CU.IdEmpresa = E.IDEMPRESA
	WHERE CU.IdEmpresa = @IdEmpresa
  AND CU.Rut = @Rut 
  
END 
