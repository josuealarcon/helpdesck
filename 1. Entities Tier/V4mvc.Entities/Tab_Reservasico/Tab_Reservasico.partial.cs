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
    public partial class Tab_Reservasico
    {
        #region [ Variables Validación ]
        public string FECHARES { get; set; }
        public int CUPOS_DISPONIBLES { get; set; }
        public int OCUPADOS { get; set; }
        public string FECHARES_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FECHARES, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHA_HOY { get; set; }
        #endregion

        #region [ Propiedades Validación ]

        #endregion

    }
}
