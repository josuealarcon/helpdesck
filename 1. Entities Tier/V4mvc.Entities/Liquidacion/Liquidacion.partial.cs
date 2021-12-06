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
		public Archivos ARCHIVO_CARGADO { get; set; }
		public string USUARIODEL { get; set; }
		public Liquidacion_Disputa DISPUTA { get; set; }
		public bool CARGO_ARCHIVO { get; set; }
		public string FECHA_FORMATEADA { get; set; }
		public string VALIDADO_NOMBRE_LARGO { get; set; }
		public ObservableCollection<Docs_Tipo_Rechazo> docs_Tipo_Rechazos { get; set; }
		public string OBSERVACION { get; set; }
		public string OBSERVACION_REVAL { get; set; }
		public Workers worker { get; set; }
		public string OBSERVACION_RE { get; set; }

		public string ACRO_EMPRESA { get; set; }

		public string STRUT_EMPRESA { get; set; }

		public string PERIODO { get; set; }

		public List<string> NOMBRES_ARCHIVOS { get; set; }

		public Guid ID_ARCHIVO { set; get; }

		public string INCLU_F301 { get; set; }
		public string OST { get; set; }

		public int RUT_PERIODO_VACIO { get; set; }
		public int PERIODO_INVALIDO { get; set; }
		public int RANGO_FECHA_INVALIDO { get; set; }
		public int RUT_INVALIDO { get; set; }
		public int REPETIDO { get; set; }

		public string RUT_ORIGINAL_ERR { get; set; }

		public string RUT_PROCESADO_ERR { get; set; }

		public string PERIODO_ERR { get; set; }

		public int INSERCION_OK { get; set; }

		public int REGISTROS_LEIDOS { get; set; }
		public int REGISTROS_INGRESADOS { get; set; }
		public int REGISTROS_INVALIDOS { get; set; }
		public int REGISTROS_REPETIDOS { get; set; }

		public int ORIGEN { get; set; }
		public string ACCION { get; set; }
		public string MSG_VALIDACION { get; set; }

		public string NOMBRE_DOC { get; set; }
		
		
		public int MAX_FILESIZE_MB { get; set; } = 256;
		public int MAX_FILES { get; set; } = 1;
		public bool ALLOW_MULTIPLE_FILES { get; set; } = false;
		public int MAX_FILENAME_LENGTH { get; set; } = 45;
		public string BASE_ALLOWED_EXTENSIONS { get; set; } = ".csv";
		public string ALLOWED_EXTENSIONS
		{
			get
			{
				return Utils.generateAllExtensions(this.BASE_ALLOWED_EXTENSIONS);
			}
		}

		public int MULTIPLE_MAX_FILESIZE_MB { get; set; } = 3;
		public int MULTIPLE_MAX_FILES { get; set; } = 1;
		public bool MULTIPLE_ALLOW_MULTIPLE_FILES { get; set; } = true;
		public int MULTIPLE_MAX_FILENAME_LENGTH { get; set; } = 45;
		public string MULTIPLE_BASE_ALLOWED_EXTENSIONS { get; set; }
		public string MULTIPLE_ALLOWED_EXTENSIONS { get; set; }
		public string ARCHIVO_ADJUNTO { get; set; }

		public string FECHA_PERIODO { get { return Utils.Fec_User(FECHA, Utils.Formato_Fecha.Periodo);  } }
		public string RUT_FORMATO
		{
			get
			{
				return Utils.strRut(RUT);
			}
		}
        public int REGISTROVAL { get; set; }
        public int REGISTROCSV { get; set; }
    }
}
