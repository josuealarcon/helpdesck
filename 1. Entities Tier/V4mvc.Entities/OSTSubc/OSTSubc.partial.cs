
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class OSTSubc
    {
        #region [ Variables ]
        private Boolean m_tiene_finicio;
        private Boolean m_tiene_ftermino;
        #endregion

        #region [ Propiedades ]
        public String NROOST { get; set; }

        public String IDEMPRESA { get; set; }

        public String FECINICIO { get; set; }
        public String FECTERM { get; set; }

        public Int16 TIENE_FINICIO { get; set; }

        public Int16 TIENE_FTERMINO { get; set; }

        public String MENSAJE_NIVEL {
            get
            {
                return (NIVEL == 0 ? "Contrato Nivel 0 = Contrato Principal" : ("Subcontrato SubNivel " + NIVEL.ToString() ));
            }
        }

        public String FRMT_FECINICIO
        {
            
            get
            {
                return (TIENE_FINICIO == 1 ? Utils.Fec_User(FECINICIO, Utils.Formato_Fecha.GuionMesLetras) : "Sin F. Ini");
            }
        }
        public String FRMT_FECTERM
        {
            get
            {
                return (TIENE_FTERMINO == 1 ? Utils.Fec_User(FECTERM, Utils.Formato_Fecha.GuionMesLetras) : "Sin F. Term");
            }
        }

        #endregion
    }
}
	