
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

		#region [ Consultas ]
		public ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_ContratOSTCtta(string NROOST)
        {
            try
            {
                return this.BL_OSTDivLocal.GetAllOSTDivLocal_ContratOSTCtta(NROOST);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	