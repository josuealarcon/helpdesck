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
	public partial class Divisiones
	{
		
		#region [ Variables Validación ]
		public int FUNCIONARIOS { get; set; }
		public int ACREDITADOS { get; set; }
		public int VEHICULOS { get; set; }
		public int CONTRATOS { get; set; }
        public bool CCHECKED { get; set; }
        #endregion

        #region [ Propiedades Validación ]

        #endregion

    }
}
