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

        #endregion

        #region [ Propiedades ]

        public string GRUPO { get; set; }

        public bool MES_ACTUAL { get; set; }

        public string PROPIOS { get; set; }

        public string VALIDACION { get; set; }

        public string DIVISIONES { get; set; }

        public string NROOST { get; set; }

        public int START { get; set;}

        public int LENGTH { get; set; }


        public int COUNT { get; set; }

        public string DESCR_ESTADO { get; set; }

        public int CUENTA_FUNC { get; set; }

        public int CUENTA_VEHI { get; set; }

        public string PROPIETARIO { get; set; }

        public int LOTEFINICIO_MENOR_HOY { get; set; }

        public int LOTEFFINAL_MENOR_HOY { get; set; }

        public String LOTEFINICIO_GML
        {
            get
            {
                return (Utils.Fec_User(LOTEFINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public String LOTEFFINAL_GML
        {
            get
            {
                return (Utils.Fec_User(LOTEFFINAL, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string LOTEFECHA_GM
        {
            get
            {
                return (Utils.Fec_User(LOTEFECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public int? SORT_COLUMN { get; set; }
        public string SORT_DIRECTION { get; set; }

        public string STR_LOTENUM { get; set; }

        public string DIV_COD { get; set; }

        public string VIGENTE { get; set; }

        public string ESTADO_EDITAR { get; set; }

        public string APRUEBA_MEDICO { get; set; }

        public string APROBACION_MEDDIV { get; set; }

        public string MENSAJE_ERROR { get; set; }

        public string EMPRESA_PASE { get; set; }

        public string FECHA_INICIO { get; set; }

        public string FECHA_FIN { get; set; }

        public string LOTEFINICIO_GM
        {
            get
            {
                return (Utils.Fec_User(LOTEFINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string LOTEFFINAL_GM
        {
            get
            {
                return (Utils.Fec_User(LOTEFFINAL, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string USUARIO { get; set; }

        public string PASE_AUTORIZADOR_OST { get; set; }

        public string PASE_AUTORIZADOR_GLOSA { get; set; }

        public string PASE_AUTORIZADOR_NOMBRES { get; set; }

        public string PASE_AUTORIZADOR_EMAIL { get; set; }

        public string PASE_AUTORIZADOR_ADMIN { get; set; }

        public string PASE_EMPRESA_RUTLOTE { get; set; }

        public string PASE_EMPRESA_NOMBRESLT { get; set; }

        public string PASE_EMPRESA_TIPOLT { get; set; }

        #endregion

    }
}
