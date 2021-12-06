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
	public partial class Docs_Fec
	{

        #region [ Variables ]

        public string OBLIGATORIO { get; set; }
        public string TIPOPASE { get; set; }
        public string ESTILO { get; set; }

        public string LICENCIAS { get; set; }

        public string FECHA { get; set; }

        public string FECHAHOY { get; set; }

        public string FECHA_FORMAT
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FECHA_PICKER
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.Guion));
            }
        }
        public string FECHAHOY_PICKER
        {
            get
            {
                return (Utils.Fec_User(FECHAHOY, Utils.Formato_Fecha.Guion));
            }
        }

        public String FECHA1 { get; set; }
        #endregion

        #region [ Propiedades ]
        public string FEC_WLOCAL { get; set; }
        #endregion


    }
}
