using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public partial class OSTSubc
    {

        #region[ Propiedades ]

        public string DIVISIONES { get; set; }
        public string USUARIO { get; set; }
        public string ZONA { get; set; }
        public string COLOR_FTERMINO { get; set; }
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string DIVISION { get; set; }
        public string DIVCOD { get; set; }
        public string IDEMPRESACONTRATISTA { get; set; }
        public string FINICIO_G { get { return (Utils.Fec_User(FINICIO, Utils.Formato_Fecha.Guion)); } }
        public string FTERMINO_G { get { return (Utils.Fec_User(FTERMINO, Utils.Formato_Fecha.Guion)); } }
        public string FECINICIO_FORMATO { get { return (Utils.Fec_User(FECINICIO, Utils.Formato_Fecha.Guion)); } }
        public string FECTERM_FORMATO { get { return (Utils.Fec_User(FECTERM, Utils.Formato_Fecha.Guion)); } }

        #endregion

    }
}
