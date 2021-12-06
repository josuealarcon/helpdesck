using System;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Controllers
{
    [SessionFilter]
    [Authorize]
    public class InformesFuncionariosController : Controller
    {
        readonly IServiceProxyClient proxy;
        #region [ Models ] 
        public class ViewModel_InformeFuncionarios
        {
            public Workers datosInformeID { get; set; }
            public LotePasesFun datosInformePase { get; set; }
            public ObservableCollection<CTRLultimo> movimientos { get; set; }
            public ObservableCollection<WorkersLocal> empresas { get; set; }
            public ObservableCollection<LotePasesFun> funcionarios { get; set; }
            public ObservableCollection<CTRLing> accesos { get; set; }
            public ObservableCollection<Casino> consumos { get; set; }
            public ObservableCollection<CursoProg> cursos { get; set; }
            public ObservableCollection<Docs> documentos1 { get; set; }
            public ObservableCollection<Docs> documentos2 { get; set; }

            public int ACCESO_FAENA { get; set; }

        }
        #endregion
        #region [ Constructor ]

        public InformesFuncionariosController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion
        public ActionResult InformeFichaFuncionarios(Workers request)
        {
            ViewModel_InformeFuncionarios model = new ViewModel_InformeFuncionarios()
            {
                datosInformeID = proxy.GetOneWorkers(request.RUT),
                movimientos = proxy.GetWorkers_GridMovimientos_FichaRut_InformeConsultaRapidaCtta(new CTRLultimo() { RUT = request.RUT }),
                empresas = proxy.GetWorkers_GridEmpresas_FichaRut_InformeConsultaRapidaCtta(new WorkersLocal() { RUT = request.RUT }),
            };
            model.datosInformeID.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }
        public ActionResult InformePasesHistoricos(LotePasesFun request)
        {
            ViewModel_InformeFuncionarios model = new ViewModel_InformeFuncionarios()
            {
                funcionarios = proxy.GetLotePasesFun_PasesHistoricos_InformeConsultasAdicionalesCtta(request),
                datosInformePase = new LotePasesFun()
            };
            model.datosInformePase.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }
        public ActionResult InformeMovimientoIngSalMesActual(CTRLing request)
        {
            ViewModel_InformeFuncionarios model = new ViewModel_InformeFuncionarios()
            {
                datosInformeID = proxy.GetOneWorkers(request.RUTINGRESO),
                accesos = proxy.GetCTRLing_Grid_Movimiento_IngSal_MesActual_InformeFuncionariosCtta(request)
            };
            model.datosInformeID.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            model.datosInformeID.PERIODO = DateTime.Now.ToString("yyyyMM");
            return View(model);
        }
        public ActionResult InformeConsumoCasinoMesActual(Casino request)
        {
            ViewModel_InformeFuncionarios model = new ViewModel_InformeFuncionarios()
            {
                datosInformeID = proxy.GetOneWorkers(request.RUT),
                consumos = proxy.GetCasino_Grid_Consumo_Casino_MesActual_InformeFuncionariosCtta(request)
            };
            model.datosInformeID.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            model.datosInformeID.PERIODO = DateTime.Now.ToString("yyyyMM");
            return View(model);
        }
        public ActionResult InformeCharlasYReservas(CursoProg request)
        {
            ViewModel_InformeFuncionarios model = new ViewModel_InformeFuncionarios()
            {
                datosInformeID = proxy.GetOneWorkers(request.RUT),
                cursos = proxy.GetCursoProg_Grid_CharlasyReservas_InformeFuncionariosCtta(request)
            };
            model.datosInformeID.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }
        public ActionResult InformeFichaFuncionarios_Detalle(Docs request)
        {
            ViewModel_InformeFuncionarios model = new ViewModel_InformeFuncionarios()
            {
                datosInformeID = proxy.GetOneWorkers(request.RUT),
                documentos1 = proxy.GetDocs_Grid1_FichaFuncionarioDetalle_InformeFuncionariosCtta(request),
                documentos2 = proxy.GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(request)
            };
            model.datosInformeID.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            model.datosInformeID.DIVISION = proxy.GetOneDivisiones(request.DIVCOD).DIVISION;
            model.datosInformeID.ACRONIMO = proxy.GetOneEnterprise(request.IDEMPRESA).ACRONIMO;
            model.datosInformeID.LICONDLT = proxy.GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(request)[0].LICONDLT;
            model.datosInformeID.ENTREGADO = proxy.GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(request)[0].ENTREGADO;
            model.datosInformeID.CERT = proxy.GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(request)[0].CERT;
            model.ACCESO_FAENA = proxy.GetDocsScalarAccesoFaena_InformeFuncionariosCtta(request.RUT, request.IDEMPRESA, request.TIPOPASE, request.DIVCOD);
            return View(model);
        }
        public ActionResult InformeMovimientoIngSalMesActual_Detalle(CTRLing request)
        {
            ViewModel_InformeFuncionarios model = new ViewModel_InformeFuncionarios()
            {
                datosInformeID = proxy.GetOneWorkers(request.RUTINGRESO),
                accesos = proxy.GetCTRLing_Grid_Movimiento_IngSal_MesActual_Detalle_InformeFuncionariosCtta(request)
            };
            model.datosInformeID.PERIODO = DateTime.Now.ToString("yyyyMM");
            model.datosInformeID.FECHA = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }
    }
}