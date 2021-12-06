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
		ObservableCollection<Docs_Disputa> GetAllDocs_Disputa();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Disputa(ref Docs_Disputa Item);
		Boolean SaveDocs_Disputa(ref ObservableCollection<Docs_Disputa> Items);
		#endregion
		
	}
}
