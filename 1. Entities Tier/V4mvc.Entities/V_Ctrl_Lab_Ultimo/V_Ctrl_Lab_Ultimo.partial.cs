
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class V_Ctrl_Lab_Ultimo
    {
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]
        public string FRMT_CERTFECHA
        {
            get
            {
                return (Utils.Fec_User(CERTFECHA, Utils.Formato_Fecha.Guion));
            }
        }

        public string FRMT_PERIODO
        {
            get
            {
                return (Utils.Fec_User(PERIODO, Utils.Formato_Fecha.Periodo));
            }
        }
        #endregion
    }
}
	