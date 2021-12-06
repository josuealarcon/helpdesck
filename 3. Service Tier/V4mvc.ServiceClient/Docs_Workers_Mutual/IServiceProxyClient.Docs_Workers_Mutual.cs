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
		ObservableCollection<Docs_Workers_Mutual> GetAllDocs_Workers_Mutual();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Workers_Mutual(ref Docs_Workers_Mutual Item);
		Boolean SaveDocs_Workers_Mutual(ref ObservableCollection<Docs_Workers_Mutual> Items);
		#endregion
		
	}
}
