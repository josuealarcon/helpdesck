using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Disputa_Trans
	{

		#region [ Consultas ]
        #endregion

        #region [ Metodos ]
        bool SaveDocDisputaTransVehiculo(Docs_Disputa Item);
        #endregion
    }
}
