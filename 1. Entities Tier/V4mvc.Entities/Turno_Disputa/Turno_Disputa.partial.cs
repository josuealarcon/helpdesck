using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace V4mvc.Entities
{
	public partial class Turno_Disputa
	{
		#region [ Variables Validación ]

		#endregion

		#region [ Propiedades Validación ]
		public String OST { get; set; }
		public Nullable<Int32> DIATRABAJO { get; set; }
		public Nullable<Int32> DIADESCANSO { get; set; }
		public String CLASETUR { get; set; }

		public Nullable<bool> NUEVA { get; set; }

		public Nullable<bool> MODO_NUEVA {
			get { return (NUEVA.HasValue && NUEVA.Value) || ESTADO == "RE"; }
		}

		public String ACRONIMO { get; set; }
		public string EMPRESA_FORMATO
		{
			get
			{
				return (Utils.strRut(EMPRESA));
			}
		}
		#endregion
	}
}
