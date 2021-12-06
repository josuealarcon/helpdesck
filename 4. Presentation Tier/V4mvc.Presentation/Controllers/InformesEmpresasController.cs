using System;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Controllers
{
    [SessionFilter]
    [Authorize]
    public class InformesEmpresasController : Controller
    {
        readonly IServiceProxyClient proxy;
        #region [ Models ] 
        public class ViewModel_InformeEmpresas
        {
            public Enterprise datosInformeFichaEmpresa { get; set; }
            public OSTArbol datosInformeContratos { get; set; }
            public ObservableCollection<A024_Divisiones> divisiones { get; set; }
            public ObservableCollection<OSTArbol> contratos { get; set; }
            public ObservableCollection<Workers> funcionarios { get; set; }
        }
        #endregion
        #region [ Constructor ]

        public InformesEmpresasController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion
        public ActionResult InformeFichaEmpresa(Enterprise request)
        {
            ViewModel_InformeEmpresas model = new ViewModel_InformeEmpresas()
            {
                datosInformeFichaEmpresa = proxy.GetOneEnterprise(request.IDEMPRESA),
                divisiones = proxy.GetA024Divisiones_GridFichaEmpresa_InformeConsultaRapidaCtta(new A024_Divisiones() { EMPRESA = request.IDEMPRESA })
            };
            if (model.datosInformeFichaEmpresa != null)
                model.datosInformeFichaEmpresa.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }
        public ActionResult InformeContratosEmpresa(OSTArbol request)
        {
            ViewModel_InformeEmpresas model = new ViewModel_InformeEmpresas();
            model.contratos = proxy.GetInformeContratosEmpresa_InformesEmpresasCtta(request);
            model.datosInformeContratos = request;
            model.datosInformeContratos.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            model.datosInformeContratos.ACRONIMO = proxy.GetOneEnterprise(request.EMPRESA).ACRONIMO;
            return View(model);
        }

        /*public ActionResult InformeFuncionarioEmpresa(Workers request) {
            ViewModel_InformeEmpresas model = new ViewModel_InformeEmpresas();
            model.funcionarios=proxy.GetInformeFuncionarioEmpresa_DivisonCtta(request);
            return View(model);
        }*/
    }
}