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
	public partial class OST
	{
		
		#region [ Propiedades ]
		public String FRMT_FECINICIO
		{
			get
			{
				return (Utils.Fec_User(FECINICIO, Utils.Formato_Fecha.Guion));
			}
		}
		public String FRMT_FECTERM
		{
			get
			{
				return (Utils.Fec_User(FECTERM, Utils.Formato_Fecha.Guion));
			}
		}

		public String FECINICIO_GML
		{
			get
			{
				return (Utils.Fec_User(FECINICIO, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public String FECTERM_GML
		{
			get
			{
				return (Utils.Fec_User(FECTERM, Utils.Formato_Fecha.GuionMesLetras));
			}
		}

		public String PERIODOS { get; set; }

		public String OOST { get; set; }
		public String OST2 { get; set; }
		public String OST3 { get; set; }

		public Nullable<Int32> ID_INSTALACION_FAENA { get; set; }

		public Nullable<Guid> ID_INF_RECEPCION { get; set; }

		public Nullable<Guid> ID_FORM_RECEPCION { get; set; }

		public String EDIFICIO_INSTALACION { get; set; }

		public String VALIDA_CARRANQUE { get; set; }

		public Nullable<Int32> CANT_DOCS_PENDIENTE { get; set; }

		public Nullable<Int32> NUM_SOLICITUD { get; set; }

		public String ESTADO_PREV { get; set; }

		public String VALIDA_PREV { get; set; }

		public int START { get; set; }
		public int LENGTH { get; set; }
		public int COLUMN { get; set; }
		public string DIRECTION { get; set; }
		public string ROL { get; set; }
		public string DESCRIPCION { get; set; }
		public string COL0 { get; set; }
		public string COL1 { get; set; }
		public string COL2 { get; set; }
		public string COL3 { get; set; }
		public string COL4 { get; set; }
		public string COL5 { get; set; }
		public string COL6 { get; set; }
		public string COL7 { get; set; }
		public int COUNT { get; set; }

		#endregion

	}
}
