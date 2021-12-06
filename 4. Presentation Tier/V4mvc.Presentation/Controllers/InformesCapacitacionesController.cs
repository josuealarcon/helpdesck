using System;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Controllers
{
    [SessionFilter]
    [Authorize]
    public class InformesCapacitacionesController : Controller
    {
        #region [ Proxy ]

        readonly IServiceProxyClient proxy;

        #endregion

        #region [ Constructor ]

        public InformesCapacitacionesController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion

        #region [ Models ]

        public class ViewModelCapacitaciones
        {
            public Charlas DETALLE { get; set; }
            public ObservableCollection<Charlas> CAPACITACIONES { get; set; }
            public Workers FUNCIONARIO { get; set; }
            public A036_CursoProg_Docs DOCS { get; set; }
        }

        public class ViewModelCapacitacionesHistorial
        {
            public ObservableCollection<Charlhist> HISTORIAL { get; set; }
            public Workers FUNCIONARIO { get; set; }
            public Charlas DETALLE { get; set; }
        }

        #endregion

        #region [ Métodos ]

        public ActionResult Index()
        {
            Charlas model = new Charlas();
            model.EMPRESA = Session["IDEMPRESA"].ToString();
            model.OPERACIONES = proxy.GetAllDivisiones();
            return View(model);
        }

        public ActionResult InformeCapacitaciones(Charlas form)
        {
            ViewModelCapacitaciones model = new ViewModelCapacitaciones();
            form.FECHAINI = string.IsNullOrEmpty(form.FECHAINI) ? null : Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.BaseDatos);
            form.FECHAFIN = string.IsNullOrEmpty(form.FECHAFIN) ? null : Utils.Fec_User(form.FECHAFIN, Utils.Formato_Fecha.BaseDatos);
            form.RUT = string.IsNullOrEmpty(form.RUT) ? null : form.RUT;
            if (form.RUT != null)
            {
                model.FUNCIONARIO = new Workers();
                model.FUNCIONARIO = proxy.GetOneWorkers(form.RUT);
            }
            model.CAPACITACIONES = proxy.GetInformeCapacitacionesCtta(ref form);
            model.DETALLE = new Charlas();
            model.DETALLE = form;
            model.DETALLE.FECHAINI = form.FECHAINI;
            model.DETALLE.FECHAFIN = form.FECHAFIN;
            model.DETALLE.FECHAINI_FORMATO = Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.GuionMesLetras);
            model.DETALLE.FECHAFIN_FORMATO = Utils.Fec_User(form.FECHAFIN, Utils.Formato_Fecha.GuionMesLetras);
            model.DETALLE.ACRONIMO = Session["ACRONIMO"].ToString();
            model.DETALLE.EMPRESA = form.EMPRESA;
            model.DETALLE.OPERACION = proxy.GetOneDivisiones(form.DIVCOD).DIVISION;
            model.DETALLE.FECHA_HOY = DateTime.Now.ToString("dd/MM/yyyy");
            return View(model);
        }

        public ActionResult InformeCapacitacionesDetalle(Charlas form)
        {
            form.FECHAINI = Utils.ConvertDatetimeToDB(form.FECHAINI);
            form.RUT = string.IsNullOrEmpty(form.RUT) ? null : form.RUT;
            ViewModelCapacitaciones model = new ViewModelCapacitaciones();
            if (form.RUT != null)
            {
                model.FUNCIONARIO = new Workers();
                model.FUNCIONARIO = proxy.GetOneWorkers(form.RUT);
            }
            model.DETALLE = new Charlas();
            model.DETALLE.CODIGO = form.CODIGO;
            if (model.DETALLE.CODIGO > 0)
                model.DOCS = proxy.GetA036CursoProgDocsCodigoCtta(model.DETALLE.CODIGO);
            model.DETALLE.IDCHARLA = form.IDCHARLA;
            if (Session["TIPOUSUARIO"].ToString() == "CTTA")
            {
                model.DETALLE.ACRONIMO = Session["ACRONIMO"].ToString();
                model.DETALLE.EMPRESA = Session["IDEMPRESA"].ToString();
            }
            model.DETALLE.FECHAINI_FORMATO = Utils.Fec_User(form.FECHAINI, Utils.Formato_Fecha.GuionMesLetras);
            model.DETALLE.FECHAINI = form.FECHAINI;
            model.DETALLE.HORA = form.HORA;
            model.DETALLE.OPERACION = form.DIVCOD;
            model.DETALLE.FINALIZADO = form.FINALIZADO;
            //model.DETALLE.CHARLA = form.CHARLA;
            model.DETALLE.FECHA_HOY = DateTime.Now.ToString("dd/MM/yyyy");
            if (form.FECHAINI == "19000101")
                form.FECHAINI = null;
            model.CAPACITACIONES = proxy.GetInformeCapacitacionesDetalleCtta(ref form);
            model.DETALLE.CHARLA = model.CAPACITACIONES[0].CHARLA;
            return View(model);
        }


        public JsonResult GetCharlasDivision(string DIVCOD)
        {
            return Json(proxy.GetAllCharlasDivisionCtta(DIVCOD), JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}