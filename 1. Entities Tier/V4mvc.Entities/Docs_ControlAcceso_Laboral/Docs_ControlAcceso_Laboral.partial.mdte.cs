using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	public partial class Docs_ControlAcceso_Laboral
	{
        public string NOMBRE_CERTUSUARIO { get; set; }
        public string APELLIDO_CERTUSUARIO { get; set; }
        public string RUT_CERTUSUARIO { get; set; }
        public string ID_CI { get; set; }
        public byte[] ADJUNTO_CONTENIDO { get; set; }
        public string ADJUNTO_TIPOCONTENIDO { get; set; }
        public string ADJUNTO_NOMBRE { get; set; }
        public string ADJUNTO_BASE64 { get; set; }
        public string VALIDADO_ARCHIVO { get; set; }
        public string CANTIDAD_DIAS { get; set; }
        public string ESTADO { get; set; }
        public int VALIDADO_DW { get; set; }
        public int ID_DISPUTA { get; set; }

        public string NOMBRE_DOCUMENTO { get; set; }
        public string CORREO { get; set; }
        public string ACRONIMO { get; set; }


        public ObservableCollection<Docs_Tipo_Rechazo> ListDocsTipoRechazo { get; set; }
        public string RUT_CERTUSUARIO_F
        {
            get { return Utils.strRut(CERTUSUARIO); }
        }
       
        public string RUT_F
        {
            get { return Utils.strRut(RUT); }
        }
        public string RUT_EMPRESA_F
        {
            get { return Utils.strRut(EMPRESA); }
        }
        public string FECHA_FIN_GML { get { return Utils.Fec_User(FECHA_FIN, Utils.Formato_Fecha.GuionMesLetras); } }
        public string FECHA_INI_GML { get { return Utils.Fec_User(FECHA_INI, Utils.Formato_Fecha.GuionMesLetras); } }
        public string CERTFECHA_GML { get { return Utils.Fec_User(CERTFECHA, Utils.Formato_Fecha.GuionMesLetras); } }


        /*

          SELECT L.EMPRESA, LD.USUARIO, LD.OBSERVACION_REVAL, L.ID_ARCHIVO 
     ,LD.ID_DISPUTA,L.ID_ARCHIVO, L.RUT ,L.FECHA_INI,L.FECHA_FIN
     , E.ACRONIMO
     ,ISNULL(W2.NOMBRES,'') AS NOMBRES
     ,ISNULL(W2.APELLIDOS,'') AS APELLIDOS
     ,ISNULL((SELECT NOMBRE FROM DOCS WHERE (ID_DOC = @ID_DOC)),'') AS NOMBRE_DOCUMENTO

          */
    }
}
