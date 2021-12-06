using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

        #endregion

        #region [ Metodos ]
        public bool SaveDocDisputaTransVehiculo(Docs_Disputa Item)
        {
            try
            {
                return this.BL_Docs_Disputa_Trans.SaveDocDisputaTransVehiculo(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
