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
    public partial class CTRLultimo
    {
        #region [ Variables Validación ]        
        public int IN_CAS { get; set; }
        public String TIPO { get; set; }
        public String DATA_GRAFIC { get; set; }
        public String FECHAIN { get; set; }
        public String FECHAOUT { get; set; }
        public String FECHACASINO { get; set; }
        public String FECHAINZ { get; set; }
        public String FECHAOUTZ { get; set; }

        public String HORAOUTZ { get; set; }
        public String HORAINZ { get; set; }
        public String HORACASINO { get; set; }
        public String HORAOUT { get; set; }
        public String HORAIN { get; set; }
        public String DIVISION { get; set; }
        public String LOCAL { get; set; }
        public String LOCALCASINO { get; set; }
        public int INZ { get; set; }
        public int OUTZ { get; set; }
        public int DIVISIONZ { get; set; }
        public int ZONA { get; set; }

        

        public string FECHAIN_LETRA
        {
            get
            {
                return (Utils.Fec_User(FECHAIN, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHAOUT_LETRA
        {
            get
            {
                return (Utils.Fec_User(FECHAOUT, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHACASINO_LETRA
        {
            get
            {
                return (Utils.Fec_User(FECHACASINO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHAINZ_LETRA
        {
            get
            {
                return (Utils.Fec_User(FECHAINZ, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FECHAOUTZ_LETRA
        {
            get
            {
                return (Utils.Fec_User(FECHAOUTZ, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        #endregion

        #region [ Propiedades Validación ]
        #endregion
    }
}
