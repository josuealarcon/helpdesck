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
	public partial class Polizas
	{
		public string NOMBRE { get; set; }
		public string COMUN { get; set; }
		public string POLIZA_VALIDADO { get; set; }
		public string POLIZAPAGO_VALIDADO { get; set; }
		public string POLIZA_VENCIDA { get; set; }
		public string PAGOALDIA { get; set; }
		public string NOMBRE_DOC { get; set; }
		public string ACRONIMO { get; set; }
		public ObservableCollection<Polizas> OSTS_COMBO { get; set; }
		public bool EXITOSO { get; set; }
		public string MENSAJE { get; set; }
		public Archivos ARCHIVO { get; set; }

		public string FECINI_LETRA
		{
			get
			{
				return (Utils.Fec_User(FECINI, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public string FECFIN_LETRA
		{
			get
			{
				return (Utils.Fec_User(FECFIN, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		
		public string FECHAMOD_LETRA
		{
			get
			{
				return (Utils.Fec_User(FECHAMOD, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public string RUT { get; set; }
		public string NOMBRES { get; set; }
		public string APELLIDOS {get; set; }
		public int ROWNUMBER { get; set; }
		public string PERINI { get; set; }
		public string PERFIN { get; set; }
		public string RUTS_DUPLICARPOLIZA { get; set; }
		public Guid? IDPAGO { get; set; }
		public int ID_TABLA { get; set; }
		
		public ObservableCollection<Polizas> Pagos { get; set; }
		public ObservableCollection<Polizas> POLIZAS_CARGADAS { get; set; }
		public ObservableCollection<Polizas> NOMINA { get; set; }
		public Docs DOCS { get; set; }

	}
}
