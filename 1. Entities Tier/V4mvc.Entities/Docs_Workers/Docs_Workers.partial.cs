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
	public partial class Docs_Workers
	{

        #region [ Variables ]

        public string EMPRESA_FORMATO
        {
            get
            {
                return Utils.strRut(EMPRESA);
            }
        }
        public string RUT_FORMATO
        {
            get
            {
                return Utils.strRut(RUT);
            }
        }

        #endregion

        #region [ Propiedades ]

        public string FECHA_MOD_FORMAT
        {
            get
            {
                return (Utils.Fec_User(FECHA_MOD, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public ObservableCollection<Docs_Tipo_Rechazo> docs_Tipo_Rechazos{ get; set; }
        public Docs_Workers_Data docs_Workers_Data { get; set; }
        public string COMUN_DIV { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string GLOSA { get; set; }
        public string NOMBRE { get; set; }
        public string DESCVALIDADO { get; set; }
        public string ESTADO { get; set; }
        public string OBSERVACION_REVAL { get; set; }
        public int ID_DISPUTA { get; set; }

        public string DIVCOD { get; set; }
        public int ID_DOC_OPCION { get; set; }

        public string REC_MSG { get; set; }
        public string NOMDIVISION { get; set; }

        #region [ Informes ]

        public string FECHAINI { get; set; }
        public string FECHAFIN { get; set; }
        public string ACRONIMO { get; set; }
        public string FECHASUBE_FORMATO
        {
            get
            {
                return Utils.Fec_User(FECHASUBE, Utils.Formato_Fecha.GuionMesLetras);
            }
        }

        #endregion


        #endregion


    }
}
