using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V4mvc.Entities
{
    public class Calendario
    {
        public DateTime FECHA { get; set; }

        public int DIA { get; set; }

        public int MES { get; set; }

        public int ANIO { get; set; }

        public string DESCRIPCION_DIA { get; set; }

        public string DESCRIPCION_MES { get; set; }

        public int COLUMNA { get; set; }

        public int FILA { get; set; }

        public string strfecha { get; set; }

        public int tipoRegistro { get; set; }
    }
}