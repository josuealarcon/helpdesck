using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public class Correo
    {
        public String Emisor { get; set; }
        public String Receptor { get; set; }
        public String Asunto { get; set; }
        public String Mensaje { get; set; }
        public List<Attachment> Attachments { get; set; }
        public Correo() { }
        public Correo(String emisor, String receptor, String asunto, String mensaje)
        {
            this.Emisor = emisor;
            this.Receptor = receptor;
            this.Asunto = asunto;
            this.Mensaje = mensaje;
        }
        public Correo(String emisor, String receptor, String asunto, String mensaje, List<Attachment> attachments)
        {
            this.Emisor = emisor;
            this.Receptor = receptor;
            this.Asunto = asunto;
            this.Mensaje = mensaje;
            this.Attachments = attachments; 
        }
    }
}
