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
		ObservableCollection<Docs_Transport> GetAllDocs_Transport();
		Docs_Transport GetOneDocs_Transport(Int32 ID_DOCS_VEH);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Transport(ref Docs_Transport Item);
		Boolean SaveDocs_Transport(ref ObservableCollection<Docs_Transport> Items);
		#endregion
		
	}
}
