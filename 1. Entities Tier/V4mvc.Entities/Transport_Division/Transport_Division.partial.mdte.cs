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
	public partial class Transport_Division
	{
		public int TRANSPORTE_DIVISION_EXISTE { get; set; }
		public int PASES_VEHICULAR_EXISTE { get; set; }
		public int PASE_DIVISION_EXISTE { get; set; }
		public int TIENE_PASE_VEHICULAR { get; set; }

		public int MUESTRA_DOCUMENTACION { get; set; }
	}
}
