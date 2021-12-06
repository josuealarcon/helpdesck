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
		ObservableCollection<Docs_Fec_Workers> GetAllDocs_Fec_Workers();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Fec_Workers(ref Docs_Fec_Workers Item);
		Boolean SaveDocs_Fec_Workers(ref ObservableCollection<Docs_Fec_Workers> Items);
		#endregion
		
	}
}
