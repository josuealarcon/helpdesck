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
	public partial class Docs_Disputa_Trans
	{
	    public string DIVCOD { get; set; }
        public string NOMBREDOCS { get; set; }
        public string ACRONIMO { get; set; }
        public string NOMBRESUSUARIO { get; set; }
        public string APELLIDOSUSUARIO { get; set; }
        public string IDEMPRESA { get; set; }
        public string USUARIOELIMINA { get; set; }

        public string USUARIO_F
        {
            get
            {
                return Utils.strRut(USUARIOELIMINA);
            }
        }
        public string IDEMPRESA_F
        {
            get
            {
                return Utils.strRut(IDEMPRESA);
            }
        }
        public string FECHA_GML
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

    }
}
