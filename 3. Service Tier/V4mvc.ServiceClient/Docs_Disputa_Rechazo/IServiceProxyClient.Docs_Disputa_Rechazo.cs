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
		ObservableCollection<Docs_Disputa_Rechazo> GetAllDocs_Disputa_Rechazo();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Disputa_Rechazo(ref Docs_Disputa_Rechazo Item);
		Boolean SaveDocs_Disputa_Rechazo(ref ObservableCollection<Docs_Disputa_Rechazo> Items);
		#endregion
		
	}
}
