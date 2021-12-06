using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using V4mvc.Entities;

namespace V4mvc.Presentation.helpers
{
    public class UploadFiles : IHttpHandler , IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            string FileName = string.Empty;
            byte[] fileData = null;
            string IdDocumento = "-1";
            if (context.Request.Files.Count > 0)
            {
                HttpFileCollection files = context.Request.Files;
                HttpPostedFile file = files[0];
                IdDocumento = files.Keys[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[1];
                Dictionary<string, Archivos> hashDocumentos = (Dictionary<string, Archivos>)HttpContext.Current.Session["hashDocumentos"]?? new Dictionary<string, Archivos>();
                Archivos archivo = new Archivos();
                archivo.EXTENSION = Path.GetExtension(file.FileName);
                archivo.NOMBRE = file.FileName;
                archivo.TIPOCONTENIDO = file.ContentType;
                using (var binaryReader = new BinaryReader(file.InputStream))
                {
                    fileData = binaryReader.ReadBytes(file.ContentLength);
                }
                archivo.ARCHIVO = fileData;
                hashDocumentos[IdDocumento] = archivo;
                HttpContext.Current.Session["hashDocumentos"] = hashDocumentos;
                FileName = file.FileName;
            }
            context.Response.Write(FileName);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

}