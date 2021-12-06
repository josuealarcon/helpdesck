using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Transport_Rechazo> GetAllDocs_Transport_Rechazo();
		Docs_Transport_Rechazo GetOneDocs_Transport_Rechazo(String PATENTE, Guid ID, Int32 ID_TIPO_RECHAZO);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Transport_Rechazo(ref Docs_Transport_Rechazo Item);
		Boolean SaveDocs_Transport_Rechazo(ref ObservableCollection<Docs_Transport_Rechazo> Items);
		#endregion
		
	}
}
