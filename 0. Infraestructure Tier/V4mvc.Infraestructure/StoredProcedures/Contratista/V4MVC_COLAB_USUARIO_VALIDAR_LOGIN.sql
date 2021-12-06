CREATE PROCEDURE [dbo].[V4MVC_COLAB_USUARIO_VALIDAR_LOGIN]
( @IdEmpresa           nvarchar(10) = NULL
, @Rut                 nvarchar(10) = NULL
, @Clave               nvarchar(50) = NULL) AS
BEGIN

   SELECT CU.IdEmpresa as IDEMPRESA , CU.Rut , CU.TipoUsuario , CU.Activo , CU.EnvioAlertas , CU.Correo_Electronico
		, ISNULL(W.NOMBRES,'') AS NOMBRES, ISNULL(W.APELLIDOS,'') AS APELLIDOS
		, ISNULL(E.ACRONIMO,'') AS ACRONIMO , ISNULL(E.NOMBRE,'') AS NOMBRE
 		, DATEDIFF(d,getdate(), ISNULL(FechaVence, dbo.hoy(getdate()))) as EXPIRA 
   FROM COLAB_USUARIO AS CU
   LEFT JOIN WORKERS AS W ON W.RUT = CU.Rut
   LEFT JOIN ENTERPRISE AS E ON E.IDEMPRESA = CU.IdEmpresa
   WHERE (CU.Rut = @Rut) 
   AND (CU.IdEmpresa = @IdEmpresa) 
   AND ( (CU.Clave = @Clave) 
		OR  ( CU.Clave = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', convert(nvarchar(50),@Clave))), 3, 32)))

END

