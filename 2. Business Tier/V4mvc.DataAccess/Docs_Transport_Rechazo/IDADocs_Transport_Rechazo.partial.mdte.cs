using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Transport_Rechazo
	{

		#region [ Consultas ]
        #endregion

        #region [ Metodos ]
        bool DeleteDocsTransportRechazoVehiculo_Mdte(Guid ID);

        bool InsertDocsTransportRechazoVehiculo_Mdte(Docs_Tipo_Rechazo model);
        #endregion
    }
}
