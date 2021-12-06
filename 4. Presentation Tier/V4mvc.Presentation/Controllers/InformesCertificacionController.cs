using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Controllers
{
    [SessionFilter]
    [Authorize]
    public class InformesCertificacionController : Controller
    {
        #region [ Proxy ]

        readonly IServiceProxyClient proxy;

        #endregion

        #region [ Constructor ]

        public InformesCertificacionController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion

        #region [ Models ] 

        public class ViewModel_InformeCertificacion
        {
            public ObservableCollection<Divisiones> divisiones { get; set; }

            public ObservableCollection<TypeTrans> tipos_vehiculo { get; set; }
            public string EMPRESA_ACRONIMO { get; set; }
            public string EMPRESA { get; set; }
            public string EMPRESA_ID_FORMATEADO { get; set; }
        }

        public class ViewModel_InformeCertResumen
        {
            public ObservableCollection<WorkersLocal> resultados { get; set; }
            public WorkersLocal resumen { get; set; }
            public string EMPRESA_ACRONIMO { get; set; }
            public string EMPRESA { get; set; }
            public string DIVISION { get; set; }

            public string DIVISION_NOMBRE { get; set; }

            public string FECHA { get; set; }
            public string EMPRESA_ID_FORMATEADO { get; set; }
        }

        public class ViewModel_InformeCertResumenOST
        {
            public ObservableCollection<WorkersLocal> resultados { get; set; }
            public WorkersLocal resumen { get; set; }
            public string EMPRESA_ACRONIMO { get; set; }
            public string EMPRESA { get; set; }
            public string DIVISION { get; set; }
            public string EMPRESA_ID_FORMATEADO { get; set; }
            public string FECHA { get; set; }
            public string DIVISION_NOMBRE { get; set; }
        }

        public class ViewModel_InformeFechaEmpDivision
        {
            public DataTable resultados { get; set; }
            public string EMPRESA_ACRONIMO { get; set; }
            public string EMPRESA { get; set; }
            public string DIVISION { get; set; }

            public string DIVISION_NOMBRE { get; set; }

            public string CAMPOS_REPORT { get; set; }

            public string CAMPOS_CONDUCCION { get; set; }

            public string CAMPOS_DOC { get; set; }
            public string CAMPOS_FEC { get; set; }

            public string HOY { get; set; }
            public string EMPRESA_ID_FORMATEADO { get; set; }
            public string FECHA { get; set; }
        }

        public class ViewModel_InformeAcreditacionVehicular
        {
            public DataTable resultados { get; set; }
            public string EMPRESA_ACRONIMO { get; set; }
            public string EMPRESA { get; set; }
            public string DIVISION { get; set; }

            public string DIVISION_NOMBRE { get; set; }

            public string CAMPOS_REPORT { get; set; }

            public string CAMPOS_CONDUCCION { get; set; }

            public string CAMPOS_DOC { get; set; }
            public string CAMPOS_FEC { get; set; }

            public string HOY { get; set; }

            public string ANIO { get; set; }
            public string COLUMNAS { get; set; }

            public string REQUISITOS { get; set; }

            public string PATENTE { get; set; }

            public string TIPO_VEHICULO { get; set; }

            public string PERIODO_DESDE { get; set; }
            public string EMPRESA_ID_FORMATEADO { get; set; }
            public string FECHA { get; set; }
        }

        public class ViewModel_InformeFechaFuncDivision
        {
            public ObservableCollection<WorkersLocal> resultados { get; set; }
            public string EMPRESA_ACRONIMO { get; set; }
            public string EMPRESA { get; set; }
            public string DIVISION { get; set; }

            public string DIVISION_NOMBRE { get; set; }

            public string CAMPOS_REPORT { get; set; }

            public string CAMPOS_CONDUCCION { get; set; }

            public string CAMPOS_DOC { get; set; }
            public string CAMPOS_FEC { get; set; }
            public string EMPRESA_ID_FORMATEADO { get; set; }
            public string HOY { get; set; }

            public string FECHA { get; set; }
        }

        public class ViewModel_InformeFechaFuncDivisionOST
        {
            public DataTable resultados { get; set; }
            public string EMPRESA_ACRONIMO { get; set; }
            public string EMPRESA { get; set; }
            public string DIVISION { get; set; }

            public string DIVISION_NOMBRE { get; set; }

            public string CAMPOS_REPORT { get; set; }

            public string CAMPOS_CONDUCCION { get; set; }

            public string CAMPOS_DOC { get; set; }
            public string CAMPOS_FEC { get; set; }

            public string HOY { get; set; }
            public string OST { get; set; }
            public string EMPRESA_ID_FORMATEADO { get; set; }
            public string FECHA { get; set; }
        }

        public class ViewModelInformeRevisionVehicular
        {
            public Reservas_Revision_Vehicular DETALLE { get; set; }
            public ObservableCollection<Reservas_Revision_Vehicular> VEHICULOS { get; set; }
            public Enterprise ENTERPRISE { get; set; }
        }

        public class ViewModelDocsPendientesFuncionarios
        {
            public ObservableCollection<Docs_Workers> DOCS { get; set; }
            public string FECHA_HOY { get; set; }
        }

        public class ViewModelDocsPendientesEmpresa
        {
            public ObservableCollection<Docs_Enterprise> DOCS { get; set; }
            public string FECHA_HOY { get; set; }
        }

        public class ViewModelDocsPendientesDisputa
        {
            public ObservableCollection<Docs_Disputa> DOCS { get; set; }
            public string FECHA_HOY { get; set; }
        }

        #endregion

        #region [ Métodos ]

        public ActionResult Index()
        {
            string EMPRESA = Session["IDEMPRESA"].ToString();
            var model = new ViewModel_InformeCertificacion()
            {
                EMPRESA = EMPRESA,
                EMPRESA_ACRONIMO = Session["ACRONIMO"].ToString(),
                divisiones = proxy.GetAllDivisiones(),
                tipos_vehiculo = proxy.GetTypeTrans_Informes()
            };
            return View(model);
        }

        public ActionResult InformeCertificacionResumen(string EMPRESA, string DIVISION)
        {
            var resumen = new WorkersLocal();
            var model = new ViewModel_InformeCertResumen()
            {
                EMPRESA = EMPRESA,
                EMPRESA_ID_FORMATEADO = Utils.strRut(EMPRESA),
                EMPRESA_ACRONIMO = Session["ACRONIMO"].ToString(),
                DIVISION_NOMBRE = proxy.GetOneDivisiones(DIVISION).DIVISION,
                DIVISION = DIVISION,
                resultados = proxy.GetAllWorkersLocal_ICertResumen_Informes(EMPRESA, DIVISION, ref resumen),
                resumen = resumen,
                FECHA = DateTime.Now.ToString("dd/MM/yyyy")
            };
            return View(model);
        }

        public ActionResult InformeCertificacionResumenOST(string EMPRESA, string DIVISION)
        {
            var resumen = new WorkersLocal();
            var model = new ViewModel_InformeCertResumenOST()
            {
                EMPRESA = EMPRESA,
                EMPRESA_ID_FORMATEADO = Utils.strRut(EMPRESA),
                EMPRESA_ACRONIMO = Session["ACRONIMO"].ToString(),
                DIVISION_NOMBRE = proxy.GetOneDivisiones(DIVISION).DIVISION,
                DIVISION = DIVISION,
                resultados = proxy.GetAllWorkersLocal_ICertResumenOST_Informes(EMPRESA, DIVISION, ref resumen),
                resumen = resumen,
                FECHA = DateTime.Now.ToString("dd/MM/yyyy")
            };
            return View(model);
        }

        public ActionResult InformeFechaEmpresaDivision(string EMPRESA, string DIVISION, string TEMP, string CERT)
        {
            WorkersLocal parametros = new WorkersLocal()
            {
                EMPRESA = EMPRESA,
                DIVISION = DIVISION,
                TEMP = TEMP,
                CERT = CERT
            };

            var ds = proxy.GetAllWorkersLocal_IFechaEmpDivision_Informes(ref parametros);

            var model = new ViewModel_InformeFechaEmpDivision()
            {
                EMPRESA = EMPRESA,
                EMPRESA_ID_FORMATEADO = Utils.strRut(EMPRESA),
                EMPRESA_ACRONIMO = Session["ACRONIMO"].ToString(),
                DIVISION = DIVISION,
                DIVISION_NOMBRE = proxy.GetOneDivisiones(DIVISION).DIVISION,
                resultados = ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable(),
                CAMPOS_REPORT = parametros.CAMPOS_REPORT,
                CAMPOS_CONDUCCION = parametros.CAMPOS_CONDUCCION,
                CAMPOS_DOC = parametros.CAMPOS_DOC,
                CAMPOS_FEC = parametros.CAMPOS_FEC,
                HOY = DateTime.Now.ToString("yyyyMMdd"),
                FECHA = DateTime.Now.ToString("dd/MM/yyyy")
            };
            return View(model);
        }

        public ActionResult InformeFechaFuncDivision(WorkersLocal parametros)
        {

            var model = new ViewModel_InformeFechaFuncDivision()
            {
                EMPRESA = parametros.EMPRESA,
                EMPRESA_ID_FORMATEADO = !string.IsNullOrEmpty(parametros.EMPRESA) ? Utils.strRut(parametros.EMPRESA) : "",
                EMPRESA_ACRONIMO = proxy.GetOneEnterprise(parametros.EMPRESA).ACRONIMO,
                DIVISION = parametros.DIVISION,
                DIVISION_NOMBRE = proxy.GetOneDivisiones(parametros.DIVISION).DIVISION,
                resultados = proxy.GetAllWorkersLocal_IFechaFuncDivision_Informes(ref parametros),
                HOY = DateTime.Now.ToString("yyyyMMdd"),
                FECHA = DateTime.Now.ToString("dd/MM/yyyy")
            };
            return View(model);
        }

        public ActionResult InformeFechaFuncDivisionOST(string EMPRESA, string DIVISION, string CERT, string OST)
        {
            WorkersLocal parametros = new WorkersLocal()
            {
                EMPRESA = EMPRESA,
                DIVISION = DIVISION,
                CERT = CERT,
                OST = OST
            };

            var ds = proxy.GetAllWorkersLocal_IFechaFuncDivisionOST_Informes(ref parametros);

            var model = new ViewModel_InformeFechaFuncDivisionOST()
            {
                EMPRESA = EMPRESA,
                EMPRESA_ID_FORMATEADO = Utils.strRut(EMPRESA),
                EMPRESA_ACRONIMO = Session["ACRONIMO"].ToString(),
                DIVISION = DIVISION,
                DIVISION_NOMBRE = proxy.GetOneDivisiones(DIVISION).DIVISION,
                resultados = ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable(),
                CAMPOS_REPORT = parametros.CAMPOS_REPORT,
                CAMPOS_CONDUCCION = parametros.CAMPOS_CONDUCCION,
                CAMPOS_DOC = parametros.CAMPOS_DOC,
                CAMPOS_FEC = parametros.CAMPOS_FEC,
                HOY = DateTime.Now.ToString("yyyyMMdd"),
                OST = OST,
                FECHA = DateTime.Now.ToString("dd/MM/yyyy")
            };
            return View(model);
        }

        public ActionResult InformeVehiculosAcreditados(string EMPRESA, string DIVISION, string PERIODO_DESDE, string PATENTE, string TIPO_VEH)
        {
            Transport parametros = new Transport()
            {
                EMPRESA = EMPRESA,
                DIVISION = DIVISION,
                PERIODO_DESDE = PERIODO_DESDE,
                PATENTE = PATENTE,
                TIPOVEHICULO = TIPO_VEH
            };

            var ds = proxy.GetAllTransport_IAcreditacionVeh_Informes(ref parametros);

            var model = new ViewModel_InformeAcreditacionVehicular()
            {
                EMPRESA = EMPRESA,
                EMPRESA_ID_FORMATEADO = Utils.strRut(EMPRESA),
                EMPRESA_ACRONIMO = Session["ACRONIMO"].ToString(),
                DIVISION = DIVISION,
                DIVISION_NOMBRE = proxy.GetOneDivisiones(DIVISION).DIVISION,
                resultados = ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable(),
                COLUMNAS = parametros.COLUMNAS,
                REQUISITOS = parametros.REQUISITOS,
                HOY = DateTime.Now.ToString("yyyyMMdd"),
                ANIO = DateTime.Now.ToString("yyyy"),
                PATENTE = PATENTE,
                TIPO_VEHICULO = string.IsNullOrEmpty(TIPO_VEH) ? "" : proxy.GetOneTypeTrans_Informes(Int32.Parse(TIPO_VEH)).DSCTIPOV,
                PERIODO_DESDE = PERIODO_DESDE,
                FECHA = DateTime.Now.ToString("dd/MM/yyyy")
            };
            return View(model);
        }

        public ActionResult InformeRevisionVehicular(Reservas_Revision_Vehicular form)
        {
            form.EMPRESA = Session["IDEMPRESA"].ToString();
            form.PATENTE = string.IsNullOrEmpty(form.PATENTE) ? null : form.PATENTE;
            form.ESTADO = string.IsNullOrEmpty(form.ESTADO) ? null : form.ESTADO;
            form.DIVISION = string.IsNullOrEmpty(form.DIVISION) ? null : form.DIVISION;
            form.FECHAINI = Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.BaseDatos);
            form.FECHAFIN = Utils.Fec_User(form.FECHAFIN, Utils.Formato_Fecha.BaseDatos);

            ViewModelInformeRevisionVehicular model = new ViewModelInformeRevisionVehicular();
            //model.VEHICULOS = proxy.GetInformeRevisionVehicularCtta(ref form);

            model.ENTERPRISE = new Enterprise();
            model.ENTERPRISE.ACRONIMO = Session["ACRONIMO"].ToString();
            model.ENTERPRISE.IDEMPRESA = form.EMPRESA;
            model.DETALLE = new Reservas_Revision_Vehicular();
            model.DETALLE.FECHAINI = Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.GuionMesLetras);
            model.DETALLE.FECHAFIN = Utils.Fec_User(form.FECHAFIN, Utils.Formato_Fecha.GuionMesLetras);
            model.DETALLE.FECHA_HOY = DateTime.Now.ToString("dd/MM/yyyy");
            model.DETALLE.ESTADO = form.ESTADO;
            if (!string.IsNullOrEmpty(form.DIVISION))
            {
                switch (form.DIVISION)
                {
                    case "LB":
                        model.DETALLE.DIVISION = "LOS BRONCES";
                        break;
                    case "LT":
                        model.DETALLE.DIVISION = "LAS TORTOLAS";
                        break;
                    case "LB,LT":
                        model.DETALLE.DIVISION = "LOS BRONCES, LAS TORTOLAS";
                        break;
                }
            }
            return View(model);
        }

        public ActionResult InformeDocsPendientesFuncionarios(Docs_Workers form)
        {
            form.FECHAINI = string.IsNullOrEmpty(form.FECHAINI) ? null : Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.BaseDatos);
            form.FECHAFIN = string.IsNullOrEmpty(form.FECHAFIN) ? null : Utils.Fec_User(form.FECHAFIN, Utils.Formato_Fecha.BaseDatos);
            form.RUT = string.IsNullOrEmpty(form.RUT) ? null : form.RUT;
            form.EMPRESA = Session["IDEMPRESA"].ToString();
            ViewModelDocsPendientesFuncionarios model = new ViewModelDocsPendientesFuncionarios();

            //model.DOCS = proxy.GetInformeDocsPendientesFuncionariosCtta(ref form);

            model.FECHA_HOY = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }

        public ActionResult InformeDocsPendientesEmpresa(Docs_Enterprise form)
        {
            form.FECHAINI = string.IsNullOrEmpty(form.FECHAINI) ? null : Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.BaseDatos);
            form.FECHAFIN = string.IsNullOrEmpty(form.FECHAFIN) ? null : Utils.Fec_User(form.FECHAFIN, Utils.Formato_Fecha.BaseDatos);
            form.EMPRESA = Session["IDEMPRESA"].ToString();
            ViewModelDocsPendientesEmpresa model = new ViewModelDocsPendientesEmpresa();

            //model.DOCS = proxy.GetInformeDocsPendientesEmpresaCtta(ref form);

            model.FECHA_HOY = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }

        public ActionResult InformeDocsPendientesDisputa(Docs_Disputa form)
        {
            form.FECHAINI = string.IsNullOrEmpty(form.FECHAINI) ? null : Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.BaseDatos);
            form.FECHAFIN = string.IsNullOrEmpty(form.FECHAFIN) ? null : Utils.Fec_User(form.FECHAFIN, Utils.Formato_Fecha.BaseDatos);
            form.RUT = string.IsNullOrEmpty(form.RUT) ? null : form.RUT;
            form.EMPRESA = Session["IDEMPRESA"].ToString();
            ViewModelDocsPendientesDisputa model = new ViewModelDocsPendientesDisputa();
            model.DOCS = proxy.GetInformeDocsPendientesDisputaCtta(ref form);
            model.FECHA_HOY = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }

        #endregion
    }
}