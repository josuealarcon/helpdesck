using System;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Controllers
{
    [SessionFilter]
    [Authorize]
    public class InformesConsultaRapidaController : Controller
    {
        readonly IServiceProxyClient proxy;
        #region [ Models ] 
        public class ViewModel_InformeConsultaRapida
        {
            public LotePasesFun datosInformePase { get; set; }
            public Workers datosInformeID { get; set; }
            public A024_Divisiones datosInformeBloqueos { get; set; }
            public Transport datosInformeFichaVehiculo { get; set; }
            public ObservableCollection<Workers> workers { get; set; }
            public ObservableCollection<LotePasesFun> funcionarios { get; set; }
            public ObservableCollection<LotePasesFun> vehiculos { get; set; }
            public ObservableCollection<Docs> documentos { get; set; }
            public ObservableCollection<A024_Divisiones> bloqueos { get; set; }

        }
        #endregion

        #region [ Constructor ]

        public InformesConsultaRapidaController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion
        public ActionResult InformeConsultaRapidaID(Workers request)
        {
            request.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            ViewModel_InformeConsultaRapida model = new ViewModel_InformeConsultaRapida()
            {
                workers = proxy.GetWorkersInformeConsultaRapidaCtta(new Workers() { RUT = request.RUT }),
                datosInformeID = request
            };

            return View(model);
        }
        public ActionResult InformeConsultaRapidaPase(LotePasesFun request)
        {
            ViewModel_InformeConsultaRapida model = new ViewModel_InformeConsultaRapida()
            {
                funcionarios = proxy.GetLotePasesFun_FuncionariosInformeConsultaRapidaCtta(request),
                vehiculos = proxy.GetLotePasesFun_VehiculosInformeConsultaRapidaCtta(request),
                datosInformePase = proxy.GetLotePasesFun_DatosPaseInformeConsultaRapidaCtta(request)
            };
            if (model.datosInformePase != null)
            {
                model.datosInformePase.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
                model.datosInformePase.SOLICITANTE = proxy.GetOneWorkers(model.datosInformePase.ADMRUT);
                if (model.datosInformePase.LOTEHORPROCESO == null)
                    model.datosInformePase.LOTEHORPROCESO = "";
            }
            return View(model);
        }

        public ActionResult _ConsultaRapida()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult ValidarNlote(int NLOTEPROC)
        {
            bool data = proxy.GetLotePasesFun_ValidaExistenciaNlote_InformeConsultaRapidaCtta(new LotePasesFun() { NLOTEPROC = NLOTEPROC }).EXISTE;
            return new JsonResult { Data = data };
        }
        public ActionResult InformeAdminColaboradorResumen(Workers request)
        {
            ViewModel_InformeConsultaRapida model = new ViewModel_InformeConsultaRapida()
            {
                datosInformeID = new Workers(),
                workers = proxy.GetWorkers_Grid_AdminColaboradorResumen_InformeConsultaRapidaCtta(request)
            };
            model.datosInformeID.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            model.datosInformeID.ACRONIMO = proxy.GetOneEnterprise(request.EMPRESA).ACRONIMO;
            return View(model);
        }
    }
}