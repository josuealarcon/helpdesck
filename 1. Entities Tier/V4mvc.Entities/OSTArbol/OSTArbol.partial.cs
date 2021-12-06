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
	public partial class OSTArbol
	{

        #region [ Variables Validación ]

        public int CANTIDAD_DOC { get; set; }
        public int CUENTA { get; set; }
        public string DESCRIPCION_DOC { get; set; }

        public int FECHA_HOY { get; set; }
        public string NOMB_ADM { get; set; }
        public string ACRONIM { get; set; }

        public string OST_NIVEL {
            get {
                return OST + "( Nivel: " + NIVEL+ " )";
            }
        }
        public string NOMBRESADMCONTR { get; set; }

        #endregion

        #region [ Informe ]

        public string ACRONIMO_MANDANTE { get; set; }
        public string ACRONIMO { get; set; }
        public string FINICIO_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FTERMINO_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FTERMINO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string MADRE_FORMATO
        {
            get
            {
                return Utils.strRut(MADRE);
            }
        }
        public string EMPRESA_FORMATO
        {
            get
            {
                return Utils.strRut(EMPRESA);
            }
        }
        public string DIVISION { get; set; }
        public string ADMINOST { get; set; }
        public string MANDANTE { get; set; }
        public string FECHA { get; set; }
        public string MANDANTE_FORMATO
        {
            get
            {
                return Utils.strRut(MANDANTE);
            }
        }
        public string ADMINOST_FORMATO
        {
            get
            {
                return Utils.strRut(ADMINOST);
            }
        }
        
        #endregion

        #region [ Propiedades Validación ]

        public int MESES { get; set; }

        #endregion



    }
}
