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
	public partial class CursoReserva
	{
        #region [ Variables]

        public string RUT_FORMATO
        {
            get
            {
                return Utils.strRut(RUT);
            }
        }
        public string FECHA { get; set; }
        public string HORA { get; set; }
        public string FECHA_FORMATO
        {
            get
            {
                return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras);
            }
        }
        public int CURSO { get; set; }
        public string MESES_RENOVACION { get; set; }
        public string CHARLA { get; set; }

        #endregion

        #region [ Propiedades  ]

        public string FECHA_NOW { get; set; }
        public string HORA_NOW { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string ACRONIMO { get; set; }
        public string FECHARES_GUION
        {
            get
            {
                return Utils.Fec_User(FECHARES, Utils.Formato_Fecha.GuionMesLetras);
            }
        }

        public int STATUS { get; set; }
        public string MENSAJE { get; set; }
        public string AUTOR { get; set; }
        public bool DOCSCOMPLETOS { get; set; }
        public string ACEPTADO { get; set; }
        public string CURSOPENDIENTE { get; set; }
        public string EMPRESAPERTENECE { get; set; }
        public string FECHA_FORMAT
        {
            get { return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras); }
        }
        public string ACRONIMOPERTENECE { get; set; }
        public int ID_GERENCIA { get; set; }
        public string ESTADO { get; set; }
        public string FINALIZAR { get; set; }
        #endregion
    }
}
