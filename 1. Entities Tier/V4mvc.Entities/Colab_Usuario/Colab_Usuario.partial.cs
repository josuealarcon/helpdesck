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
	public partial class Colab_Usuario
	{

        #region [ Variables]

        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        public String IDEMPRESA { get; set; }
        public String ACRONIMO { get; set; }
        public String NOMBRE { get; set; }
        public int EXPIRA { get; set; }

        public String UCREADOR { get; set; }
        public string URL { get; set; }

        #endregion

        #region [ Propiedades  ]

        public string Correo_Electronico_O
        {
            get { return Utils.EmailOculto(Correo_Electronico); }
        }
     
        #endregion

    }
}
