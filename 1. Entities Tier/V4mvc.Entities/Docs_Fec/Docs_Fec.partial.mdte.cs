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

        #endregion

        #region [ Propiedades ]

        public string FECHA_HOY { get; set; }

        public string FECHA_REGISTRADA { get; set; }

        public int EXISTE_SOLICITADOFECHA { get; set; }

        public int TIPO_FECHA { get; set; }

        public string FECHA_REGISTRADA_GM
        {
            get
            {
                return (Utils.Fec_User(FECHA_REGISTRADA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FECHA_GM
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FECHA_GMF
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras, (string.IsNullOrEmpty(ESTILO) ? false : true)));
            }
        }

        public string COLOR { get; set; }
        public string OBLIGADO { get; set; }
        public string INFORMACION { get; set; }

        #endregion


    }
}
