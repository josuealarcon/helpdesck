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
        public string NOMBRE { get; set; }

        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public Archivos ARCHIVO { get; set; }
        public Docs_ControlAcceso_Laboral_Disputa DISPUTA { get; set; }
        public ObservableCollection<Docs_Tipo_Rechazo> docs_Tipo_Rechazos { get; set; }
        public Workers worker { get; set; }
        public string OBSERVACION { get; set; }
        public string OBSERVACION_REVAL { get; set; }
        public string OBSERVACION_RE { get; set; }
        public string VALIDADO_DESC { get; set; }
        public string FECHA_INI_FORMAT { get; set; }
        public string FECHA_FIN_FORMAT { get; set; }
        public string FECHA_INI_FORMAT_GUION { get { return (Utils.Fec_User(FECHA_INI, Utils.Formato_Fecha.GuionMesLetras)); } }
        public String FECHASUBE_GUION { get { return (Utils.Fec_User(FECHASUBE, Utils.Formato_Fecha.Periodo)); } }
        public string USUARIO_FORMATO { get { return Utils.strRut(USUARIO); } }
        public string PERIODO { get; set; }
    }
}
