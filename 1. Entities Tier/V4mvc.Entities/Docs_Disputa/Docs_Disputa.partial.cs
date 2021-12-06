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
	public partial class Docs_Disputa
	{

        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        #endregion

        #region [ Informes ]

        public string FECHAINI { get; set; }
        public string FECHAFIN { get; set; }
        public string COMUN_DIV { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string ACRONIMO { get; set; }
        public string NOMBRE { get; set; }
        public string ID_TIPO_PROPIETARIO { get; set; }
        public string FECHA_FORMATO
        {
            get
            {
                return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras);
            }
        }
        public string EMPRESA_FORMATO
        {
            get
            {
                return Utils.strRut(EMPRESA);
            }
        }
        public string RUT_FORMATO
        {
            get
            {
                switch (ID_TIPO_PROPIETARIO)
                {
                    case "1":
                        return Utils.strRut(RUT);
                    case "2":
                        return Utils.strRut(RUT);
                    case "3":
                        return Utils.FormatoPatente(RUT);
                    case "4":
                        return RUT;
                    default:
                        return RUT;
                }
            }
        }

        #endregion

    }
}
