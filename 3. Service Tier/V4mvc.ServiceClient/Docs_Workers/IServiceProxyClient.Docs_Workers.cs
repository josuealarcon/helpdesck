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
		ObservableCollection<Docs_Workers> GetAllDocs_Workers();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Workers(ref Docs_Workers Item);
		Boolean SaveDocs_Workers(ref ObservableCollection<Docs_Workers> Items);
		#endregion
		
	}
}
