using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class CursosProgramados
    {
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        public string FECHA_GML
        {
            get { return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras); }
        }

        public string FECHA_G
        {
            get { return Utils.Fec_User(FECHA, Utils.Formato_Fecha.Guion); }
        }

        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public string CHARLA { get; set; }
        public int TAB { get; set; }
        public int COUNT { get; set; }
        public string DIVISIONES { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public string COL4 { get; set; }
        public string COL5 { get; set; }

        #endregion
    }
}