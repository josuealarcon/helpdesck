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
	public partial class Remulogproceso
	{
        public String FECHA { get; set; }
        public String PERIODOCOSULTA { get; set; }
        public String MUTUAL { get; set; }
        public String ACRONIMO { get; set; }        
        public String VALIDADOPREVIRED { get; set; }
        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        public String FPROCESO_LETRA { get; set; }
        public String DIVISION { get; set; }
        public String TIPOPASE { get; set; }
        public String EMPRESA_COD { get; set; }
        public String RUT_COD { get; set; }
        public String IMPONIBLE_P_COD { get; set; }

        //Paginacion
        public int LENGTH { get; set; }
        public int START { get; set; }
        public int TOTALREGISTROS { get; set; }
        public int ROWNUMBER { get; set; }
        public String TP_CUMPLE { get; set; }
    }
}
