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
	public partial class Direccion
	{

        #region [ Variables Validación ]

        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        public string TIPO { get; set; }
        public string NOMCONTACTO { get; set; }
        public string CELCONTACTO { get; set; }
        public int CCIUDAD { get; set; }
        public ObservableCollection<Direccion> regiones { get; set; }
        #endregion

        #region [ Propiedades Validación ]

        #endregion


    }
}
