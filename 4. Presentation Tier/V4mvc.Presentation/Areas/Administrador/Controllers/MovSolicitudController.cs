using System.Collections.ObjectModel;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Areas.Usuario.Controllers
{
    [SessionFilter]
    public class MovSolicitudController : Controller
    {

        #region [ Proxy ]

        readonly IServiceProxyClient proxy;

        #endregion

        #region [ Constructor ]

        public MovSolicitudController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion

        #region [ Modelos ]


        #endregion

        #region [ Métodos ]
        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region [ Consultas ]

        public ActionResult GetListSolicitudes(Solicitud ITEM)
        {
            var result = proxy.GetListSolicitudes_Usu(ref ITEM);

            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult CrearEditar()
        {
            Solicitud modelsolicitud = new Solicitud();
            return View(modelsolicitud);   
        }
        #endregion

    }
}