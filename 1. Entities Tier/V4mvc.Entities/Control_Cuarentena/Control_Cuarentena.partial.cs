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
	public partial class Control_Cuarentena
	{
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string EMAIL { get; set; }
        public string FECHAHOY { get; set; }
        public ObservableCollection<Cuarentena_Detalle> CUARENTENA_DETALLE { get; set; }
        public List<string> DIAS_SEMANA{ get; set; }
        public int DIAINI { get; set; }
        public string FECHA_INI
        {
            get
            {
                return (Utils.Fec_User(FECHAINI, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FECHA_FIN
        {
            get
            {
                return (Utils.Fec_User(FECHAFIN, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string ESTADO { get; set; }
    }
}
