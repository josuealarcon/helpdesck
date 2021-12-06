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
		ObservableCollection<Docs_Workers_Data> GetAllDocs_Workers_Data();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Workers_Data(ref Docs_Workers_Data Item);
		Boolean SaveDocs_Workers_Data(ref ObservableCollection<Docs_Workers_Data> Items);
		#endregion
		
	}
}
