using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{ 
    public partial class Docs_Disputa
    {
        #region [ Propiedades ]

        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string NOMBREDOCUMENTO { get; set; }
        public string DIVCOD { get; set; }
        public string TURNO { get; set; }
        public string GLOSA { get; set; }
        public string ID_CI { get; set; }       
        public string NOMBRE_CERTUSUARIO { get; set; }
        public string APELLIDO_CERTUSUARIO { get; set; }
        public string RUT_CERTUSUARIO { get; set; }
        public string EMPRESADOCS { get; set; }
        public string TURNODOCS { get; set; }
        public string OSTDOCS { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string NOMDIVISION { get; set; }
        public string ID_DOC_ARCHIVO { get; set; }
        public byte[] ADJUNTO_CONTENIDO { get; set; }
        public string ADJUNTO_TIPOCONTENIDO { get; set; }
        public string ADJUNTO_NOMBRE { get; set; }
        public string ADJUNTO_BASE64 { get; set; }
        public string ARCHIVO_ID { get; set; }
        public ObservableCollection<Docs_Tipo_Rechazo> ListDocsTipoRechazo { get; set; }
        public Docs_Workers_Data dataDocsWorkersData { get; set; }
        public ObservableCollection<Docs_Workers> ListDocsWorkerDocsApoyo{ get; set; }
        public ObservableCollection<Docs_Tipo_Rechazo> ListDocsTipoRechazoVehiculos { get; set; }
        public string RUT_F
        {
            get { return ID_TIPO_PROPIETARIO == 3 ? Utils.FormatoPatente(RUT) : Utils.strRut(RUT); }
        }

        public string PATENTE_F
        {
            get { return Utils.FormatoPatente(RUT); }
        }

        public string RUT_CERTUSUARIO_F
        {
            get { return ID_TIPO_PROPIETARIO == 3 ? Utils.FormatoPatente(CERTUSUARIO) : Utils.strRut(CERTUSUARIO);  }
        }        

        public string IDEMPRESA_F
        {
            get { return Utils.strRut(EMPRESA); }
        }

        public string FECHA_GML { get { return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras); } }

        public string CERTFECHA_GML
        {
            get { return Utils.Fec_User(CERTFECHA, Utils.Formato_Fecha.GuionMesLetras); }

        }

        #endregion
    }
}
