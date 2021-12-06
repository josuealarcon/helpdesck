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
		ObservableCollection<Docs_TipoPase> GetAllDocs_TipoPase();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_TipoPase(ref Docs_TipoPase Item);
		Boolean SaveDocs_TipoPase(ref ObservableCollection<Docs_TipoPase> Items);
		#endregion
		
	}
}
