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
		ObservableCollection<Docs_Fec> GetAllDocs_Fec();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Fec(ref Docs_Fec Item);
		Boolean SaveDocs_Fec(ref ObservableCollection<Docs_Fec> Items);
		#endregion
		
	}
}
