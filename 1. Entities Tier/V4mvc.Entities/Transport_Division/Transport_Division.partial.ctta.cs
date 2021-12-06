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
        public ObservableCollection<Transport_Division_Pases> ListPasesAutorizado { get; set; }
        public string PASES_VEHICULARES { get; set; }
        public ObservableCollection<Docs> ListDocumentos { get; set; }
        public string PATENTE_FORMATO
        {
            get
            {
                return (Utils.FormatoPatente(PATENTE));
            }
        }
        public Enterprise Empresa { get; set; }
        public string DOCUMENTACION { get; set; }
        public string ACRONIMO { get; set; }
        public string CERTVEH { get; set; }
        public Transport transport { get; set; }

    }
}
