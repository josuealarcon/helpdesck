
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class Region
    {
        #region [ Variables ]

        #endregion

		#region [ Propiedades ]

        public string REGION_PAIS { get { return PAIS + " >> " + REGION; } }

		#endregion
	}
}
	