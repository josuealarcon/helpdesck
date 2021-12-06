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
    public partial class Informes_Certificacion
    {
        #region [ Variables Validación ]
        public String EMPRESA { get; set; }
        public String ACRONIMO { get; set; }
        public Int32 MANDANTE { get; set; }
        public Int32 MANDANTE_SUM
        {
            get 
            {
                return SI + NO;
            } 
        }
        public Int32 SI { get; set; }
        public Int32 NO { get; set; }
        public Int32 BL { get; set; }
        #endregion

        #region [ Propiedades Validación ]
        #endregion
    }
}
