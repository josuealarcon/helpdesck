using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Configuration;
using V4mvc.Entities;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using System.Web.Helpers;

namespace V4mvc.Presentation.helpers
{
    public class SendNotification
    {
        public string Notification(string Nombre_Remitente,string RUT_Destinatario, string RoomName)
        {
            var fecha = (DateTime.Now.Year + string.Empty) +
                        (DateTime.Now.Month.ToString().Length < 2 ? "0" + DateTime.Now.Month : DateTime.Now.Month + string.Empty) +
                        (DateTime.Now.Day.ToString().Length < 2 ? "0" + DateTime.Now.Day : DateTime.Now.Day + string.Empty);
            var hora = (DateTime.Now.Hour.ToString() + string.Empty) + ":" +
            (DateTime.Now.Minute.ToString()) + ":" + "00";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            object input = new
            {
                Remitente = Nombre_Remitente,
                Rut = RUT_Destinatario,
                Mensaje = "Prueba de Notificacion 6",
                Fecha = fecha,
	            Hora = hora,
	            Estado = "0",
	            Metadata = RoomName,
	            Asunto = "Prueba Llamada"
            };
            String inputJson = (new JavaScriptSerializer()).Serialize(input);
            var response = client.UploadString(@"http://m3.webcontrolcorp.com/ws/webcontrol/api/api/messages", inputJson);
            return response;
        }

        public string Token(string RUT, string RUT_Destinatario)
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            object input = new
            {
                workerId = RUT
            };
            String inputJson = (new JavaScriptSerializer()).Serialize(input);
            var response = client.UploadString(@"http://m3.webcontrolcorp.com/ws/anglo/api/v2/worker/authenticate", inputJson);
            dynamic jObj = JsonConvert.DeserializeObject(response);
            string token = jObj.Data;

            WebClient client1 = new WebClient();
            client1.Headers["Content-type"] = "application/json";
            client1.Headers.Set("Authorization", token);
            var response_1 = client1.DownloadString(@"http://m3.webcontrolcorp.com/ws/anglo/api/v2/twlat/" + RUT + "/" + RUT_Destinatario);
            dynamic jObj_1 = JsonConvert.DeserializeObject(response_1);
            string token_sala = jObj_1.Data;

            return token_sala;
        }
    }
}