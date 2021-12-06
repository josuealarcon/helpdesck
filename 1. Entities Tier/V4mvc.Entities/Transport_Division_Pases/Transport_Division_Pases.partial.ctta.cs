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
	public partial class Transport_Division_Pases
	{
		public string FECHAINI_F { get { return Utils.Fec_User(FINIPASE, Utils.Formato_Fecha.GuionMesLetras); } }
		public string FECHAFIN_F { get { return Utils.Fec_User(FFINPASE, Utils.Formato_Fecha.GuionMesLetras); } }
        //public string NROOST { get; set; }
        
    }
}
