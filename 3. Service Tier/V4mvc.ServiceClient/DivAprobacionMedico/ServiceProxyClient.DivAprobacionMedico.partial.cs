
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

		#region [ Consultas ]
		public  DivAprobacionMedico GetOneDivAprobacionMedico_PasesCtta(string DIVCOD)
        {
            try
            {
                return this.BL_DivAprobacionMedico.GetOneDivAprobacionMedico_PasesCtta(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	