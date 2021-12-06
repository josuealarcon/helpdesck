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
    public partial class LotePases
    {

        #region [ Variables ]

        public string LOTEFINICIO_FORMAT
        {
            get
            {
                return (Utils.Fec_User(LOTEFINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string LOTEFFINAL_FORMAT
        {
            get
            {
                return (Utils.Fec_User(LOTEFFINAL, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int NUMFUNCIONARIOS { get; set; }
        public int NUMVEHICULOS { get; set; }

        #endregion

        #region [ Propiedades ]
        public String DIVCOD { get; set; }

        public String TPASE { get; set; }

        public String OSTLT { get; set; }

        public String TIPO_PASE { get; set; }

        public String W_OST { get; set; }

        public String W_NOMBRES { get; set; }

        public String W_EMAIL { get; set; }

        public String ACRONIMO { get; set; }

        public String DESC_ESTADO { get; set; }

        public Nullable<Int32> FUN { get; set; }
        public Nullable<Int32> EMP { get; set; }
        public Nullable<Int32> VEH { get; set; }
        public Nullable<Int32> TOD { get; set; }

        public String W_ADMIN { get; set; }

        public String LOTEFECHA_FRMTD
        {
            get
            {
                return (Utils.Fec_User(LOTEFECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public String LOTEFINICIO_FRMTD
        {
            get
            {
                return (Utils.Fec_User(LOTEFINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public String LOTEFFINAL_FRMTD
        {
            get
            {
                return (Utils.Fec_User(LOTEFFINAL, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public int IDPASE { get; set; }

        public string IDEMPRESA { get; set; }
        public string EMAIL_AUT { get; set; }
        public string RUT_AUT { get; set; }

        public int ACTIVADO_DELEGADO_OST { get; set; }

        public int RET_OK { get; set; }

        public string JSON_RET { get; set; }

        #endregion

    }
}
