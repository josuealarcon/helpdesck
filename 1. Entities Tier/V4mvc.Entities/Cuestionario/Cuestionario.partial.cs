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
	public partial class Cuestionario
	{
        public ObservableCollection<Alternativa> LIST_ALTERNATIVAS { get; set; }
		
	}
}
