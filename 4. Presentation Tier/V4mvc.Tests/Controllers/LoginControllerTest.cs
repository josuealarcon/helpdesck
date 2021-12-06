using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Unity.AspNet.Mvc;
using V4mvc.Entities;
using System.Collections.ObjectModel;

namespace V4mvc.Tests.Controllers
{
    [TestClass]
    public class LoginControllerTest
    {
        readonly IServiceProxyClient proxy;
        private IUnityContainer container;

        [TestInitialize]
        public void Initialize()
        {
            container = new UnityContainer();

            container.RegisterType<V4mvc.DataAccess.IDataAccessEnterprise, V4mvc.DataAccess.DataAccessEnterprise>(TypeLifetime.PerThread);

            container.RegisterType<V4mvc.DataAccess.IDAAdmin, V4mvc.DataAccess.DAAdmin>();
            container.RegisterType<V4mvc.DataAccess.IDAColab_Usuario, V4mvc.DataAccess.DAColab_Usuario>();
            container.RegisterType<V4mvc.DataAccess.IDADireccion, V4mvc.DataAccess.DADireccion>();
            container.RegisterType<V4mvc.DataAccess.IDADivisiones, V4mvc.DataAccess.DADivisiones>();
            container.RegisterType<V4mvc.DataAccess.IDAEnterprise, V4mvc.DataAccess.DAEnterprise>();
            container.RegisterType<V4mvc.DataAccess.IDALocal, V4mvc.DataAccess.DALocal>();
            container.RegisterType<V4mvc.DataAccess.IDAOST, V4mvc.DataAccess.DAOST>();
            container.RegisterType<V4mvc.DataAccess.IDAOSTArbol, V4mvc.DataAccess.DAOSTArbol>();
            container.RegisterType<V4mvc.DataAccess.IDARol, V4mvc.DataAccess.DARol>();
            container.RegisterType<V4mvc.DataAccess.IDARoles, V4mvc.DataAccess.DARoles>();
            container.RegisterType<V4mvc.DataAccess.IDATab_TipoPase, V4mvc.DataAccess.DATab_TipoPase>();
            container.RegisterType<V4mvc.DataAccess.IDATab_TipoPase_Division, V4mvc.DataAccess.DATab_TipoPase_Division>();
            container.RegisterType<V4mvc.DataAccess.IDATurnos, V4mvc.DataAccess.DATurnos>();
            container.RegisterType<V4mvc.DataAccess.IDAWC_Menu, V4mvc.DataAccess.DAWC_Menu>();
            container.RegisterType<V4mvc.DataAccess.IDAWC_SubMenu, V4mvc.DataAccess.DAWC_SubMenu>();
            container.RegisterType<V4mvc.DataAccess.IDAWorkers, V4mvc.DataAccess.DAWorkers>();
            container.RegisterType<V4mvc.DataAccess.IDAWorkersLocal, V4mvc.DataAccess.DAWorkersLocal>();


            container.RegisterType<V4mvc.BusinessLogic.IBLAdmin, V4mvc.BusinessLogic.BLAdmin>();
            container.RegisterType<V4mvc.BusinessLogic.IBLColab_Usuario, V4mvc.BusinessLogic.BLColab_Usuario>();
            container.RegisterType<V4mvc.BusinessLogic.IBLDireccion, V4mvc.BusinessLogic.BLDireccion>();
            container.RegisterType<V4mvc.BusinessLogic.IBLDivisiones, V4mvc.BusinessLogic.BLDivisiones>();
            container.RegisterType<V4mvc.BusinessLogic.IBLEnterprise, V4mvc.BusinessLogic.BLEnterprise>();
            container.RegisterType<V4mvc.BusinessLogic.IBLLocal, V4mvc.BusinessLogic.BLLocal>();
            container.RegisterType<V4mvc.BusinessLogic.IBLOST, V4mvc.BusinessLogic.BLOST>();
            container.RegisterType<V4mvc.BusinessLogic.IBLOSTArbol, V4mvc.BusinessLogic.BLOSTArbol>();
            container.RegisterType<V4mvc.BusinessLogic.IBLRol, V4mvc.BusinessLogic.BLRol>();
            container.RegisterType<V4mvc.BusinessLogic.IBLRoles, V4mvc.BusinessLogic.BLRoles>();
            container.RegisterType<V4mvc.BusinessLogic.IBLTab_TipoPase, V4mvc.BusinessLogic.BLTab_TipoPase>();
            container.RegisterType<V4mvc.BusinessLogic.IBLTab_TipoPase_Division, V4mvc.BusinessLogic.BLTab_TipoPase_Division>();
            container.RegisterType<V4mvc.BusinessLogic.IBLTurnos, V4mvc.BusinessLogic.BLTurnos>();
            container.RegisterType<V4mvc.BusinessLogic.IBLWC_Menu, V4mvc.BusinessLogic.BLWC_Menu>();
            container.RegisterType<V4mvc.BusinessLogic.IBLWC_SubMenu, V4mvc.BusinessLogic.BLWC_SubMenu>();
            container.RegisterType<V4mvc.BusinessLogic.IBLWorkers, V4mvc.BusinessLogic.BLWorkers>();
            container.RegisterType<V4mvc.BusinessLogic.IBLWorkersLocal, V4mvc.BusinessLogic.BLWorkersLocal>();

            container.RegisterType<V4mvc.IServiceProxyClient, V4mvc.ServiceProxyClient>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        [TestMethod]
        public void ValidarInstancia() {
            Assert.IsNotNull(container, "La Instancia no deberia ser nula");
        }

        [TestMethod]
        public void ValidarUsuario()
        {

            // Arrange
            //LoginController controller = new LoginController(container.Resolve<IServiceProxyClient>());

            //ObservableCollection<Admin> admins =  container.Resolve<IServiceProxyClient>().GetAllAdmin();

            //Parallel.ForEach<Admin>(admins, delegate (Admin item) {
            //    JsonResult result2 = controller.ValidarUsuario(item.ADMRUT) as JsonResult;
            //    Assert.AreEqual(true, result2.Data);
            //});

            //JsonResult result = controller.ValidarUsuario("132192219") as JsonResult;
            //JsonResult result1 = controller.ValidarUsuario(String.Empty) as JsonResult;
            

            ////// Assert
            //IDictionary<String, object> data = (IDictionary<String, object>)new System.Web.Routing.RouteValueDictionary(result.Data);
            //Assert.AreEqual(true, result.Data);
            //Assert.AreEqual(false, result1.Data);

            
        }

    }
}
