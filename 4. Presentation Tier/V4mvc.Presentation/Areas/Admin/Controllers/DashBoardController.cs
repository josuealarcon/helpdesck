using System;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using V4mvc.Entities;
using V4mvc.Presentation.helpers;

namespace V4mvc.Presentation.Areas.Mandante.Controllers
{
    [SessionFilter]
    public class DashBoardController : Controller
    {

        #region [ Proxy ]

        readonly IServiceProxyClient proxy;

        #endregion

        #region [ Constructor ]

        public DashBoardController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }

        #endregion

        #region [ Models ]

        public class ViewModelMenu
        {
            public ObservableCollection<WC_Menu> menu { get; set; }
            public ObservableCollection<WC_SubMenu> subMenu { get; set; }
            public Admin admin { get; set; }
            public Colab_Usuario colab_usuario { get; set; }
        }

        #endregion

        #region [ Métodos ]

        public ActionResult DashBoard()
        {
            //if (string.IsNullOrEmpty(proxy.GetOneDireccion(Session["USUARIO"].ToString()).CELULAR) ||
            //    string.IsNullOrEmpty(proxy.GetOneEnterprise(Session["IDEMPRESA"].ToString()).TELEFONO))
            //    return RedirectToAction("ActualizaContactoMdte", "DashBoard");
            //else
                return RedirectToAction("_DashBoardMDTE", "DashBoard");
        }

        public ActionResult _DashBoardMDTE()
        {
            return PartialView(proxy.GetDashBoardMdte(Session["USUARIO"].ToString()));
        }

        public ActionResult _Menu()
        {
            ViewModelMenu model = new ViewModelMenu();
            if ((ViewModelMenu)Session["Menu"] == null)
            {
                switch (Session["TIPOUSUARIO"].ToString())
                {
                    case Constants.USUARIO_CONTRATISTA:
                        model.menu = proxy.GetAllMenuCtta();
                        model.subMenu = proxy.GetAllSubMenuCtta(Session["NIVELUSUARIO"].ToString());
                        break;
                    case Constants.USUARIO_MANDANTE:
                        model.menu = proxy.GetAllMenuMdte();
                        model.subMenu = proxy.GetAllSubMenuMdte(Session["GRUPO"].ToString(), Session["ZONA"].ToString());
                        break;
                    default:
                        break;
                }
                Session["Menu"] = model;
            }
            else
                model = (ViewModelMenu)Session["Menu"];

            return PartialView(model);
        }

        #endregion

    }
}