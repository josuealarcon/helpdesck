using System;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Controllers
{
    [SessionFilter]
    [Authorize]
    public class InformesVehiculosController : Controller
    {
        readonly IServiceProxyClient proxy;
        #region [ Models ] 
        public class ViewModel_InformeVehiculos
        {
            public Transport datosInformeFichaVehiculo { get; set; }
            public ObservableCollection<A024_Divisiones> divisiones { get; set; }

        }
        #endregion

        #region [ Constructor ]

        public InformesVehiculosController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion
        public ActionResult InformeFichaVehiculo(Transport request)
        {
            ViewModel_InformeVehiculos model = new ViewModel_InformeVehiculos()
            {
                divisiones = proxy.GetAllA024Divisiones_InformeConsultaRapidaCtta(new A024_Divisiones() { PATENTE = request.PATENTE }),
                datosInformeFichaVehiculo = proxy.GetTransport_DatosFichaVehiculo_InformeConsultaRapidaCtta(request)
            };
            model.datosInformeFichaVehiculo.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }
    }
}