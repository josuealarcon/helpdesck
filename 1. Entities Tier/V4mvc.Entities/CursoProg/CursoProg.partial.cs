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
	public partial class CursoProg
	{
        public string FECHA_FORMAT
        {
            get { return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras)); }
        }
        public string FECHA_GML
        {
            get { return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras)); }
        }

        public string DIVISIONES { get; set; }
        public string CHARLA { get; set; }
        public string CAPACIDAD { get; set; }
        public string CANTIDAD { get; set; }
        public string OBLIGATORIO { get; set; }
        public string HORAS { get; set; }
        public string UBICACION { get; set; }
        public string ACTIVA { get; set; }
        public string RUT { get; set; }
        public string DIVISION { get; set; }
        public string CUENTASI { get; set; }
        public string CUENTANO { get; set; }
        public string PARTICIPANTES { get; set; }
        public int CUENTASI_REPORTE { get; set; }
        public int CUENTANO_REPORTE { get; set; }
        public int PARTICIPANTES_REPORTE { get; set; }
        public string ACRONIMO { get; set; }
        public string DIVCOD { get; set; }

        public int RESTRICCION { get; set; }
        public string DOCS_LT { get; set; }
        public string DOCS_LB { get; set; }
        public string DOCS_ES { get; set; }
        public string DOCS_CH { get; set; }
        public string EMPRESA { get; set; }
        public string PUEDE_PEDIR_PASE { get; set; }

        public string MENSAJE { get; set; }

        #region [ func_getdatos ]

        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string AUTOR { get; set; }
        public bool DOCSCOMPLETOS { get; set; }

        #endregion
        public int STATUS { get; set; }
        public string FECHANOW { get; set; }
        public string FECHAHOY { get { return (Utils.Fec_User(FECHANOW, Utils.Formato_Fecha.GuionMesLetras)); } }
        public string CURSOPENDIENTE { get; set; }
        public string EMPRESAPERTENECE { get; set; }
        public string ACEPTADO { get; set; }
        public string ACRONIMOPERTENECE { get; set; }
        public string USUARIO { get; set; }
        public ObservableCollection<CursoReserva> LIST_CURSORESERVA { get; set; }
        public Enterprise ENTERPRISE { get; set; }
        public DateTime HORATERMINO { get; set; }
        public string HORAFIN {
            get { return HORATERMINO.ToString("HH:mm:ss");}
        }
        public string NOMIMPRIME { get; set; }
        public ObservableCollection<Gerencia> GERENCIAS { get; set; }
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
    }
}
