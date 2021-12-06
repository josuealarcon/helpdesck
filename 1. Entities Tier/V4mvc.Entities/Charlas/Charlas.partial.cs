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
	public partial class Charlas
	{
		public string EMPRESA { get; set; }
		public ObservableCollection<Divisiones> OPERACIONES { get; set; }

        #region [ Informe ]

		public Int32 CODIGO { get; set; }
		public string FECHA_HOY { get; set; }
		public string OPERACION { get; set; }
		public string ACRONIMO { get; set; }
		public string DIVCOD { get; set; }
		public string FECHAINI { get; set; }
		public string FECHAFIN { get; set; }
		public string FECHAINI_FORMATO { get; set; }
		public string FECHAFIN_FORMATO { get; set; }
		public string RUT { get; set; }

		public string CURSOS_MES { get; set; }
		public string RUT_FORMATO
		{
			get
			{
				return Utils.strRut(RUT);
			}
		}
		public string EMPRESA_FORMATO
		{
			get
			{
				return Utils.strRut(EMPRESA);
			}
		}
		public string FECHA { get; set; }
		public string FECHA_FORMATO
		{
			get
			{
				return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras);
			}
		}
		public string HORA { get; set; }
		public string FINALIZADO { get; set; }
		public string CUENTASI { get; set; }
		public string CUENTANO { get; set; }
		public string PARTICIPANTES { get; set; }
		public string NOMBRES { get; set; }
		public string APELLIDOS { get; set; }
		public string NOTA { get; set; }
		public string ASISTIO { get; set; }
		public string EXPIRA { get; set; }
		public string EXPIRA_FORMATO
        {
			get
			{
				return Utils.Fec_User(EXPIRA, Utils.Formato_Fecha.GuionMesLetras);
			}
		}
		public int START { get; set; }
		public int LENGTH { get; set; }
		public string COLUMN { get; set; }
		public string DIRECTION { get; set; }
		public int COUNT { get; set; }
		public string TIPOUSUARIO { get; set; }
		public string COL0 { get; set; }
		public string COL1 { get; set; }
		public string COL2 { get; set; }
		public string COL3 { get; set; }
        public string DIVISIONES { get; set; }
        #endregion

    }
}
