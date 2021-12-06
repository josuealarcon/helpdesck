
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class A056_Form30_1_Det
    {
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]
        public String FRMT_PERIODO
        {
            get
            {
                return (Utils.Fec_User(PERIODO, Utils.Formato_Fecha.Guion));
            }
        }
        #endregion
    }
}
	