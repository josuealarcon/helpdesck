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
	public partial class Alternativa
	{
		public Nullable<Boolean> CHECKED { get; set; }

        public string DATO { get; set; }

        public string COMENTARIO { get; set; }

    }
}
