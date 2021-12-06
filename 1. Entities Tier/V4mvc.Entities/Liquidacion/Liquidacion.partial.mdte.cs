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
	public partial class Liquidacion
	{
		public string NOMBRES { get; set; }
		public string APELLIDOS { get; set; }
        public string NOMBRE { get; set; }
        public string ESTADO { get; set; }
        public string ACRONIMO { get; set; }
        public string NOMBRE_CERTUSUARIO { get; set; }
        public string APELLIDO_CERTUSUARIO { get; set; }
        public string RUT_CERTUSUARIO { get; set; }
        public string GRATIFICACION { get; set; }
        public string SUELDOBASE { get; set; }
        public string ID_DOC_ARCHIVO { get; set; }
        public byte[] ADJUNTO_CONTENIDO { get; set; }
        public string ADJUNTO_TIPOCONTENIDO { get; set; }
        public string ADJUNTO_NOMBRE { get; set; }
        public string ADJUNTO_BASE64 { get; set; }
        public string VALIDADO_DOCS_WORKERS { get; set; }
        public string ID_DISPUTA { get; set; }
        public ObservableCollection<Docs_Tipo_Rechazo> ListDocsTipoRechazo { get; set; }
        public ObservableCollection<Docs_Tipo_Rechazo> ListDocsTipoRechazoLiquidacion { get; set; }
        public Docs_Workers_Data dataDocsWorkersData { get; set; }
        public ObservableCollection<Liquidacion_Disputa> ListLiquidacionDocsApoyo { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string APELLIDO_USUARIO { get; set; }
        public string CORREO { get; set; }
        public string NOMBRE_DOCUMENTO { get; set; }

        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public string COL4 { get; set; }
        public string COL5 { get; set; }
        public string COL6 { get; set; }
        public string DWVALIDADO { get; set; }
        public string CERTIFICADOR { get; set; }
        public string NOM_CERTIFICADOR { get; set; }
        public ObservableCollection<Docs_Workers_Rechazo> ListMotivosRechazo { get; set; }
        public ObservableCollection<Docs_Tipo_Rechazo> ListDocsRechazo { get; set; }
        public string ARCHIVOBase64 { get; set; }
        public Nullable<Guid> ID_CEDULA { get; set; }
        public string ARCHIVOBase64_1 { get; set; }


        public string RUT_LIQUIDACION
        {
            get { return Utils.strRut(RUT); }
        }

        public string RUT_USUARIO_F
        {
            get { return Utils.strRut(USUARIO); }
        }

        public string RUT_CERTUSUARIO_F
        {
            get { return ID_TIPO_PROPIETARIO == 3 ? Utils.FormatoPatente(CERTUSUARIO) : Utils.strRut(CERTUSUARIO); }
        }
        public string RUT_F
        {
            get { return ID_TIPO_PROPIETARIO == 3 ? Utils.FormatoPatente(RUT) : Utils.strRut(RUT); }
        }
      
        public string RUTEMPRESA_F
        {
            get { return Utils.strRut(EMPRESA); }
        }
        public string FECHA_GML { get { return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras); } }

        public string CERTFECHA_GML
        {
            get
            {
                return Utils.Fec_User(CERTFECHA, Utils.Formato_Fecha.GuionMesLetras);
            }
        }
    }
}
