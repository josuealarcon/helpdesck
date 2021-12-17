using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using V4mvc.Entities;
using System.Configuration;
using System.Net;
using System.Web;

namespace V4mvc.Presentation
{
    public class LoginController : Controller
    {

        #region [ proxy ]

        readonly IServiceProxyClient proxy;

        #endregion

        #region [ Constructor ]

        public LoginController() { }
        public LoginController(IServiceProxyClient proxy) { this.proxy = proxy; }

        #endregion

        #region [ Métodos ]

        [HttpGet]
        public ActionResult Login()
        {
            Session["INTENTOS"] = 0;
            if (User.Identity.IsAuthenticated && Session["VALIDACION"] != null)
            {
                return RedirectToAction("DashBoard", "DashBoard");
            }
            Admin model = new Admin();
            return View(model);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Login(Admin model)
        {
            if (ModelState.IsValid)
            {
                int intentos = 0;
                if (intentos <= 3)
                {
                    ViewBag.Message = "";
                    Session["INTENTOS"] = 0;
                    switch (model.TIPOUSUARIO)
                    {
                        case Constants.USUARIO_CONTRATISTA:
                            Colab_Usuario colab_usuario = proxy.ValidarLoginColab_Usuario(model.ADMRUTEMPRESA, model.ADMRUT, model.ADMCLAVE);
                            if (colab_usuario != null)
                            {
                                if (colab_usuario.Activo == "SI")
                                {
                                    if (colab_usuario.EXPIRA == 0)
                                    {
                                        Session["USUARIO"] = model.ADMRUT;
                                        Session["IDEMPRESA"] = model.ADMRUTEMPRESA;
                                        return Json(new KeyValuePair<string, string>("CambioClave", "CTTA"), JsonRequestBehavior.AllowGet);
                                    }
                                    else if (colab_usuario.EXPIRA > 0)
                                    {
                                        if (!string.IsNullOrEmpty(colab_usuario.IDEMPRESA))
                                        {
                                            HttpCookie cookie = Request.Cookies["URL_USER"];
                                            Session["TIPOUSUARIO"] = Constants.USUARIO_CONTRATISTA;
                                            Session["IDEMPRESA"] = model.ADMRUTEMPRESA;
                                            Session["FUNCIONARIO"] = colab_usuario.NOMBRES + " " + colab_usuario.APELLIDOS;
                                            Session["ACRONIMO"] = colab_usuario.ACRONIMO;
                                            Session["EMPRESA"] = colab_usuario.NOMBRE;
                                            Session["USUARIO"] = model.ADMRUT;
                                            Session["NIVELUSUARIO"] = colab_usuario.TipoUsuario;
                                            Session["INTENTOS"] = 0;
                                            FormsAuthentication.SetAuthCookie(Constants.USUARIO_CONTRATISTA, true);
                                            if (cookie != null)
                                            {
                                                return Json(new KeyValuePair<string, string>("URL", cookie.Value), JsonRequestBehavior.AllowGet);
                                            }
                                            else
                                            {
                                                return Json(new KeyValuePair<string, string>("Usuario", ""), JsonRequestBehavior.AllowGet);
                                            }
                                        }
                                        else
                                        {
                                            return Json(new KeyValuePair<string, string>("Error", "Empresa no existe"), JsonRequestBehavior.AllowGet);
                                        }
                                    }
                                    else
                                    {
                                        //bloquear
                                    }
                                }
                                else
                                {
                                    return Json(new KeyValuePair<string, string>("Error", "Usuario se encuentra bloqueado, comuniquese con el administración del sistema."), JsonRequestBehavior.AllowGet);
                                }
                            }
                            else
                            {
                                return Json(new KeyValuePair<string, string>("Error", "Usuario o Contraseña incorrectos"), JsonRequestBehavior.AllowGet);
                            }
                            break;
                        case Constants.USUARIO_MANDANTE:
                            Admin admin = proxy.ValidarLoginAdmin(model.ADMRUT, model.ADMCLAVE);
                            if (admin != null)
                            {
                                if (admin.ACTIVO == "SI")
                                {
                                    if (admin.EXPIRA == 0)
                                    {
                                        Session["USUARIO"] = model.ADMRUT;
                                        return Json(new KeyValuePair<string, string>("CambioClave", "MDTE"), JsonRequestBehavior.AllowGet);
                                    }
                                    else if (admin.EXPIRA > 0)
                                    {
                                        HttpCookie cookie = Request.Cookies["URL_MDTE"];
                                        Session["TIPOUSUARIO"] = Constants.USUARIO_MANDANTE;
                                        Session["USUARIO"] = model.ADMRUT;
                                        Session["GRUPO"] = admin.ADMTIPO;
                                        Session["ZONA"] = admin.ADMLUGAR;
                                        Session["LOCAL"] = admin.ADMLOCAL;
                                        Session["EMPRESA"] = admin.ADMRUTEMPRESA;
                                        Session["IDEMPRESA"] = admin.ADMRUTEMPRESA;
                                        Session["PUERTOS"] = admin.ADMPUERTOS;
                                        Session["EMAIL"] = admin.ADMEMAIL;
                                        Session["DIVISIONES"] = admin.ADMDIVISION;
                                        Session["INTENTOS"] = 0;
                                        FormsAuthentication.SetAuthCookie(Constants.USUARIO_MANDANTE, true);
                                        if (cookie != null)
                                        {
                                            return Json(new KeyValuePair<string, string>("URL", cookie.Value), JsonRequestBehavior.AllowGet);
                                        }
                                        else
                                        {
                                            return Json(new KeyValuePair<string, string>("Admin", ""), JsonRequestBehavior.AllowGet);
                                        }
                                    }
                                    else
                                    {
                                        //bloquear
                                    }
                                }
                                else
                                {
                                    return Json(new KeyValuePair<string, string>("Error", "Usuario se encuentra bloqueado, para desbloquear siga el link: Olvido Contraseña."), JsonRequestBehavior.AllowGet);
                                }
                            }
                            else
                            {
                                return Json(new KeyValuePair<string, string>("Error", "Usuario o Contraseña incorrectos"), JsonRequestBehavior.AllowGet);
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                    return Json("Ha ingresado mal la contraseña 3 veces intentelo en unos minutos", JsonRequestBehavior.AllowGet);
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult CambioClave(string TIPOUSUARIO)
        {
            Session["USUARIOTIPO"] = TIPOUSUARIO;
            return View();
        }

        [HttpPost]
        [Obsolete]
        public ActionResult CambioClaveTipoUsuario(string NUEVACLAVE)
        {
            string hostName = Dns.GetHostName();
            var IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string ID = Session["USUARIO"].ToString();
            string IDEMPRESA = string.Empty;
            switch (Session["USUARIOTIPO"].ToString())
            {
                case Constants.USUARIO_CONTRATISTA:
                    IDEMPRESA = Session["IDEMPRESA"].ToString();
                    Colab_Usuario colab_usuario = proxy.GetOneColabUsuario_Ctta(IDEMPRESA, ID);
                    EmailPassword(IDEMPRESA, colab_usuario.Rut, colab_usuario.NOMBRES, colab_usuario.APELLIDOS, NUEVACLAVE, colab_usuario.Correo_Electronico, IP);
                    proxy.CambioClaveHistoricoCtta(ID, IDEMPRESA, NUEVACLAVE, IP);
                    proxy.CambioClaveCtta(ID, IDEMPRESA, NUEVACLAVE);
                    break;
                case Constants.USUARIO_MANDANTE:
                    Admin admin = proxy.GetOneAdmin(ID);
                    EmailPassword(IDEMPRESA, admin.ADMRUT, admin.NOMBRES, admin.APELLIDOS, NUEVACLAVE, admin.ADMEMAIL, IP);
                    proxy.CambioClaveHistoricoMdte(ID, NUEVACLAVE, IP);
                    proxy.CambioClaveMdte(ID, NUEVACLAVE);
                    break;
                default: break;
            }
            Admin form = new Admin();
            form.TIPOUSUARIO = Session["USUARIOTIPO"].ToString();
            form.ADMRUTEMPRESA = IDEMPRESA;
            form.ADMRUT = ID;
            form.ADMCLAVE = NUEVACLAVE;
            return this.Login(form);
        }

        public JsonResult ValidarClave(string CLAVE)
        {
            bool data = false;
            switch (Session["USUARIOTIPO"].ToString())
            {
                case Constants.USUARIO_CONTRATISTA:
                    data = proxy.ValidarClaveCtta(Session["USUARIO"].ToString(), Session["IDEMPRESA"].ToString(), CLAVE);
                    break;
                case Constants.USUARIO_MANDANTE:
                    data = proxy.ValidarClaveMdte(Session["USUARIO"].ToString(), CLAVE);
                    break;
                default: break;
            }
            return new JsonResult { Data = data };
        }

        public JsonResult ValidarClaveHistorico(string CLAVE)
        {
            bool data = false;
            switch (Session["USUARIOTIPO"].ToString())
            {
                case Constants.USUARIO_CONTRATISTA:
                    data = proxy.ValidarClaveHistoricoCtta(Session["USUARIO"].ToString(), Session["IDEMPRESA"].ToString(), CLAVE);
                    break;
                case Constants.USUARIO_MANDANTE:
                    data = proxy.ValidarClaveHistoricoMdte(Session["USUARIO"].ToString(), CLAVE);
                    break;
                default: break;
            }
            return new JsonResult { Data = data };
        }

        public ActionResult RecoverPassword() { return View(); }

        [HttpPost]
        [Obsolete]
        public JsonResult RecoverPassword(string IDEMPRESA, string RUT, string TIPOUSUARIO)
        {
            bool data = false;
            string hostName = Dns.GetHostName();
            var IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string NEWPASSWORD = Utils.GenerarClave();
            string correo = "";
            switch (TIPOUSUARIO)
            {
                case Constants.USUARIO_CONTRATISTA:
                    Colab_Usuario colab_usuario = proxy.GetOneColabUsuario_Ctta(IDEMPRESA, RUT);
                    if (colab_usuario != null)
                    {
                        if (colab_usuario.Activo == "SI")
                        {
                            EmailPassword(IDEMPRESA, colab_usuario.Rut, colab_usuario.NOMBRES, colab_usuario.APELLIDOS, NEWPASSWORD, colab_usuario.Correo_Electronico, IP);
                            proxy.UpdateClaveColabUsuario(IDEMPRESA, RUT, NEWPASSWORD);
                            correo = colab_usuario.Correo_Electronico_O;
                            data = true;
                        }
                    }
                    break;
                case Constants.USUARIO_MANDANTE:
                    Admin admin = proxy.GetOneAdmin(RUT);
                    if (admin != null)
                    {
                        if (admin.ACTIVO == "BL" || admin.ACTIVO == "SI")
                        {
                            EmailPassword(string.Empty, admin.ADMRUT, admin.NOMBRES, admin.APELLIDOS, NEWPASSWORD, admin.ADMEMAIL, IP);
                            proxy.UpdateClaveAdmin(RUT, NEWPASSWORD);
                            correo = admin.ADMEMAIL_O;
                            data = true;
                        }
                    }
                    break;
                default: break;
            }
            return Json(new { Data = data, correo = correo }, JsonRequestBehavior.AllowGet);
        }

        public void EmailPassword(string IDEMPRESA, string RUT, string NOMBRES, string APELLIDOS, string NEWPASSWORD, string EMAIL, string IP)
        {
            string TIEMPO_FULL = DateTime.Now.ToString("HH:mm:ss");
            string FECHA_FULL = DateTime.Now.ToString("dd-MM-yyyy");
            string LONG_OWNER = "Mantos Copper";
            var mail_params = new HtmlCuerpoCorreoArgs();

            mail_params.HTML_RECEPTOR = "Estimado(a) Usuario :" + NOMBRES + " " + APELLIDOS;
            mail_params.HTML_CUERPO = "Adjuntamos Nueva clave de acceso para utilizar los servicios de Webcontrol";
            mail_params.HTML_TABLA_TITULO = String.Empty;
            mail_params.HTML_DESPEDIDA = "Atentamente,<br><b>Servicio Administracion Webcontrol " + LONG_OWNER + "</b><br><br>" + TIEMPO_FULL + " | " + FECHA_FULL + "<br><br>";
            mail_params.HTML_PIEPAGINA = "Web Control";

            mail_params.HTML_TABLA_PARAMETROS = new List<KeyValuePair<string, string>>();
            if (!string.IsNullOrEmpty(IDEMPRESA)) { mail_params.HTML_TABLA_PARAMETROS.Add(new KeyValuePair<string, string>("ID Empresa :", IDEMPRESA)); }
            mail_params.HTML_TABLA_PARAMETROS.Add(new KeyValuePair<string, string>("ID :", RUT));
            mail_params.HTML_TABLA_PARAMETROS.Add(new KeyValuePair<string, string>("Nueva Clave :", NEWPASSWORD));
            mail_params.HTML_TABLA_PARAMETROS.Add(new KeyValuePair<string, string>("IP :", IP));
            string htmlString = RazorViewToString.RenderRazorViewToString(this, "~/Views/Shared/TemplateEmail.cshtml", mail_params);

            if (!Request.IsLocal)
            {
                Correo mail = new Correo(ConfigurationManager.AppSettings["CorreoEnvio"].ToString(), EMAIL, "Cambio de Clave", htmlString, null);
                new SendEmail().EnviarEmail(mail);
            }
        }

        public ActionResult NewEnterpriseCtta() { return View(); }

        public ActionResult DataNewEnterpriseCtta(string IDEMPRESA)
        {
            Enterprise model = new Enterprise();
            model.IDEMPRESA = IDEMPRESA;
            return View(model);
        }

        [HttpPost]
        public ActionResult DataNewEnterpriseCtta(Enterprise model)
        {
            if (ModelState.IsValid)
            {
                proxy.SaveNewEnterpriseCTTA(ref model);

                Colab_Usuario colab_usuario = new Colab_Usuario();
                colab_usuario.IdEmpresa = model.IDEMPRESA;
                colab_usuario.Rut = model.ADMINRUT;
                colab_usuario.Clave = model.CLAVE;
                colab_usuario.Correo_Electronico = model.ADMINEMAIL;
                proxy.SaveColabUsuarioNewEnterpriseCTTA(ref colab_usuario);

                Workers workers = new Workers();
                workers.RUT = model.ADMINRUT;
                workers.EMPRESA = model.IDEMPRESA;
                workers.NOMBRES = model.ADMNOM;
                workers.APELLIDOS = model.ADMINAPE;
                proxy.SaveWorkersNewEnterpriseCTTA(ref workers);

                Session["TIPOUSUARIO"] = Constants.USUARIO_CONTRATISTA;
                Session["IDEMPRESA"] = model.IDEMPRESA;
                Session["FUNCIONARIO"] = model.ADMNOM + ' ' + model.ADMINAPE;
                Session["ACRONIMO"] = model.ACRONIMO;
                Session["EMPRESA"] = model.NOMBRE;
                Session["USUARIO"] = model.ADMINRUT;
                Session["NIVELUSUARIO"] = "ADMIN";
                Session["INTENTOS"] = 0;
                FormsAuthentication.SetAuthCookie(Constants.USUARIO_CONTRATISTA, true);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ValidarRUT(string RUT) { return new JsonResult { Data = Utils.ValidarRUT(RUT) }; }

        [HttpPost]
        public JsonResult ValidarColabUsuarioExiste(string IDEMPRESA, string RUT)
        {
            var colab_usuario = proxy.GetOneColabUsuario_Ctta(IDEMPRESA, RUT);
            var worker = proxy.GetOneWorkers(RUT);
            return new JsonResult { Data = colab_usuario == null && worker == null && Utils.ValidarRUT(RUT) ? true : false };
        }

        [HttpPost]
        public JsonResult ValidarEnterprise(string IDEMPRESA) { return new JsonResult { Data = proxy.GetOneEnterprise(IDEMPRESA) != null ? true : false }; }

        public JsonResult ObtenerAutorEnterprise(string IDEMPRESA)
        {
            Enterprise enterprise = proxy.GetOneEnterprise(IDEMPRESA);
            if (enterprise != null)
            {
                return Json(enterprise.AUTOR, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("NULL", JsonRequestBehavior.AllowGet);
            }
        }



        public ActionResult LogOff()
        {
            if (Request.Cookies["URL_CTTA"] != null)
            {
                var c = new HttpCookie("URL_CTTA");
                c.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(c);
            }
            if (Request.Cookies["URL_MDTE"] != null)
            {
                var c = new HttpCookie("URL_MDTE");
                c.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(c);
            }
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Login", new { area = "" });
        }

        public ActionResult RedirectToLogin()
        {
            Session.Abandon();
            FormsAuthentication.RedirectToLoginPage();
            return PartialView("_RedirectToLogin");
        }

      

        #endregion

    }
}
