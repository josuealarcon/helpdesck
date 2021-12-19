using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using V4mvc.Entities;

namespace V4mvc.Presentation.Controllers
{
    public class MasterController : Controller
    {
        readonly IServiceProxyClient proxy;
        public MasterController(IServiceProxyClient proxy)
        {
            this.proxy = proxy;
        }
        
        public class ViewModelAdmin
        {
            public Admin admin { get; set; }
            public Colab_Usuario colab_usuario { get; set; }
        }

       

        public ActionResult _ActualizaContacto()
        {
            return PartialView();
        }

        public ActionResult _NavBar()
        {
            ViewModelAdmin model = new ViewModelAdmin();
            switch (Session["TIPOUSUARIO"].ToString())
            {
                case Constants.USUARIO_USUARIO:
                    model.colab_usuario = proxy.GetOneColabUsuario_Ctta(Session["IDEMPRESA"].ToString(), Session["USUARIO"].ToString());
                    break;

                case Constants.USUARIO_ADMINISTRADOR:
                    model.admin = proxy.GetOneAdmin(Session["USUARIO"].ToString());
                    break;
            }
            return PartialView(model);
        }

        public ActionResult _MainPerfil()
        {
            ViewModelAdmin model = new ViewModelAdmin();
            switch (Session["TIPOUSUARIO"].ToString())
            {
                case Constants.USUARIO_USUARIO:
                    model.colab_usuario = proxy.GetOneColabUsuario_Ctta(Session["IDEMPRESA"].ToString(), Session["USUARIO"].ToString());
                    break;

                case Constants.USUARIO_ADMINISTRADOR:
                    model.admin = proxy.GetOneAdmin(Session["USUARIO"].ToString());
                    break;
            }
            return PartialView(model);
        }

        public JsonResult ObtenerArchivo(string ID)
        {
            Archivos file = proxy.GetOneArchivos(Guid.Parse(ID));
            file.CONTENIDO_BASE64 = Convert.ToBase64String(file.ARCHIVO, 0, file.ARCHIVO.Length);
            file.ARCHIVO = null;
            return Json(new { model = file, OK = true }, JsonRequestBehavior.AllowGet);
        }

        
       
    }
}