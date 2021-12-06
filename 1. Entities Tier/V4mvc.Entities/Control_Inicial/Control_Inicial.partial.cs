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
	public partial class Control_Inicial
	{
		public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string FECHA_HORA
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras) + HORA);
            }
        }

        public string FECHA_INGRESO
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
    }
}
