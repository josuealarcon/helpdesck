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
		ObservableCollection<Docs_Workers_Rechazo> GetAllDocs_Workers_Rechazo();
		Docs_Workers_Rechazo GetOneDocs_Workers_Rechazo(String RUT, Guid ID, Int32 ID_TIPO_RECHAZO);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Workers_Rechazo(ref Docs_Workers_Rechazo Item);
		Boolean SaveDocs_Workers_Rechazo(ref ObservableCollection<Docs_Workers_Rechazo> Items);
		#endregion
		
	}
}
