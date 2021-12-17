using System.Web.Mvc;
using Unity.AspNet.Mvc;
using Unity;
using Unity.Injection;
using V4mvc.DataAccess;
using System.Configuration;

namespace V4mvc.Presentation
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            container.RegisterType<IDbFactory, DbFactory>(new InjectionConstructor(connectionString));
            container.RegisterType<V4mvc.DataAccess.IDataAccessEnterprise, V4mvc.DataAccess.DataAccessEnterprise>(new PerRequestLifetimeManager());

            //----------------------[BEGIN DATA-ACCESS CLASS/INTERFACE MAPPING]------------------------------------------------
            container.RegisterType<V4mvc.DataAccess.IDAAdmin, V4mvc.DataAccess.DAAdmin>();
            container.RegisterType<V4mvc.DataAccess.IDAColab_Usuario, V4mvc.DataAccess.DAColab_Usuario>();
            container.RegisterType<V4mvc.DataAccess.IDAGerencia, V4mvc.DataAccess.DAGerencia>();
            container.RegisterType<V4mvc.DataAccess.IDARol, V4mvc.DataAccess.DARol>();
            container.RegisterType<V4mvc.DataAccess.IDARoles, V4mvc.DataAccess.DARoles>();
            container.RegisterType<V4mvc.DataAccess.IDAServicio, V4mvc.DataAccess.DAServicio>();
            container.RegisterType<V4mvc.DataAccess.IDAWC_Menu, V4mvc.DataAccess.DAWC_Menu>();
            container.RegisterType<V4mvc.DataAccess.IDAWC_SubMenu, V4mvc.DataAccess.DAWC_SubMenu>();
            container.RegisterType<V4mvc.DataAccess.IDAWorkers, V4mvc.DataAccess.DAWorkers>();          
            container.RegisterType<V4mvc.DataAccess.IDAColab_WC_SubMenu, V4mvc.DataAccess.DAColab_WC_SubMenu>();           
            container.RegisterType<V4mvc.DataAccess.IDAE200_Datos, V4mvc.DataAccess.DAE200_Datos>();
            container.RegisterType<V4mvc.DataAccess.IDAE200_Dothh, V4mvc.DataAccess.DAE200_Dothh>();
            container.RegisterType<V4mvc.DataAccess.IDAGerencias, V4mvc.DataAccess.DAGerencias>();
            container.RegisterType<V4mvc.DataAccess.IDAGerencias_Area, V4mvc.DataAccess.DAGerencias_Area>();
            container.RegisterType<V4mvc.DataAccess.IDAArchivos, V4mvc.DataAccess.DAArchivos>();
            container.RegisterType<V4mvc.DataAccess.IDAEnterprise, V4mvc.DataAccess.DAEnterprise>();
            container.RegisterType<V4mvc.DataAccess.IDAWorkers, V4mvc.DataAccess.DAWorkers>();
            container.RegisterType<V4mvc.DataAccess.IDASolicitud, V4mvc.DataAccess.DASolicitud>();

            //----------------------[END DATA-ACCESS CLASS/INTERFACE MAPPING]------------------------------------------------

            //----------------------[BEGIN BUSINESS LOGIC CLASS/INTERFACE MAPPING]-------------------------------------------
            container.RegisterType<V4mvc.BusinessLogic.IBLAdmin, V4mvc.BusinessLogic.BLAdmin>();
            container.RegisterType<V4mvc.BusinessLogic.IBLColab_Usuario, V4mvc.BusinessLogic.BLColab_Usuario>();
            container.RegisterType<V4mvc.BusinessLogic.IBLGerencia, V4mvc.BusinessLogic.BLGerencia>();
            container.RegisterType<V4mvc.BusinessLogic.IBLRol, V4mvc.BusinessLogic.BLRol>();
            container.RegisterType<V4mvc.BusinessLogic.IBLRoles, V4mvc.BusinessLogic.BLRoles>();
            container.RegisterType<V4mvc.BusinessLogic.IBLServicio, V4mvc.BusinessLogic.BLServicio>();
            container.RegisterType<V4mvc.BusinessLogic.IBLWC_Menu, V4mvc.BusinessLogic.BLWC_Menu>();
            container.RegisterType<V4mvc.BusinessLogic.IBLWC_SubMenu, V4mvc.BusinessLogic.BLWC_SubMenu>();
            container.RegisterType<V4mvc.BusinessLogic.IBLColab_WC_SubMenu, V4mvc.BusinessLogic.BLColab_WC_SubMenu>();
            container.RegisterType<V4mvc.BusinessLogic.IBLE200_Datos, V4mvc.BusinessLogic.BLE200_Datos>();
            container.RegisterType<V4mvc.BusinessLogic.IBLE200_Dothh, V4mvc.BusinessLogic.BLE200_Dothh>();
            container.RegisterType<V4mvc.BusinessLogic.IBLGerencias, V4mvc.BusinessLogic.BLGerencias>();
            container.RegisterType<V4mvc.BusinessLogic.IBLGerencias_Area, V4mvc.BusinessLogic.BLGerencias_Area>();
            container.RegisterType<V4mvc.BusinessLogic.IBLArchivos, V4mvc.BusinessLogic.BLArchivos>();
            container.RegisterType<V4mvc.BusinessLogic.IBLEnterprise, V4mvc.BusinessLogic.BLEnterprise>();
            container.RegisterType<V4mvc.BusinessLogic.IBLWorkers, V4mvc.BusinessLogic.BLWorkers>();
            container.RegisterType<V4mvc.BusinessLogic.IBLSolicitud, V4mvc.BusinessLogic.BLSolicitud>();
            //----------------------[END BUSINESS LOGIC CLASS/INTERFACE MAPPING]-------------------------------------------

            container.RegisterType<V4mvc.IServiceProxyClient, V4mvc.ServiceProxyClient>(new PerRequestLifetimeManager());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}