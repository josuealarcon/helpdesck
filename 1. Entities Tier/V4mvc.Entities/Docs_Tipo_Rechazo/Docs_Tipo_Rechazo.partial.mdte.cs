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
	public partial class Docs_Tipo_Rechazo
	{
        public Int32 _ID_TIPO_RECHAZO { get; set; }
        public bool CHECKED { get; set; }
        public Guid ID { get; set; }
        public string RUT { get; set; }
        public string USUARIO { get; set; }
        public int CANTIDAD_CHECKED { get; set; }
    }
}
