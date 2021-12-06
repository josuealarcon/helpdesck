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

        public class ViewModelVideosVista
        {
            public ObservableCollection<LinksVideosV4> links { get; set; }
        }

        public ActionResult _ActualizaContacto()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult ActualizaContacto(string Telefono, string celular)
        {
            proxy.SaveEnterpriseTelefono(Telefono, Session["IDEMPRESA"].ToString());
            proxy.SaveDireccionCelularRut(celular, Session["USUARIO"].ToString());
            return RedirectToAction("DashBoard", "DashBoard");
        }

        public ActionResult _NavBar()
        {
            ViewModelAdmin model = new ViewModelAdmin();
            switch (Session["TIPOUSUARIO"].ToString())
            {
                case Constants.USUARIO_CONTRATISTA:
                    model.colab_usuario = proxy.GetOneColabUsuario_Ctta(Session["IDEMPRESA"].ToString(), Session["USUARIO"].ToString());
                    break;

                case Constants.USUARIO_MANDANTE:
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
                case Constants.USUARIO_CONTRATISTA:
                    model.colab_usuario = proxy.GetOneColabUsuario_Ctta(Session["IDEMPRESA"].ToString(), Session["USUARIO"].ToString());
                    break;

                case Constants.USUARIO_MANDANTE:
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

        public ContentResult ObtenerVideo(string ID)
        {
            Videos video = proxy.GetOneVideos(ID);
            video.CONTENIDO_BASE64 = Convert.ToBase64String(video.ARCHIVO, 0, video.ARCHIVO.Length);
            video.ARCHIVO = null;
            video.TIPO_CONTENIDO = video.TIPO_CONTENIDO == "application/octet-stream" && video.EXTENSION == ".mp4" ? "video/mp4" : video.TIPO_CONTENIDO;
            

            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            // For simplicity just use Int32's max value.
            // You could always read the value from the config section mentioned above.
            serializer.MaxJsonLength = Int32.MaxValue;

            var resultData = new { model = video, OK = true };
            var result = new ContentResult
            {
                Content = serializer.Serialize(resultData),
                ContentType = "application/json"
            };

            return result;

            //return Json(new { model = video, OK = true }, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult _VideosVista(string KEY)
        {
            KEY = Utils.fromBase64Decode(KEY);
            ViewModelVideosVista modelo = new ViewModelVideosVista
            {
                links = proxy.GetVideoLinks(KEY)
            };
            return PartialView(modelo);
        }
    }
}