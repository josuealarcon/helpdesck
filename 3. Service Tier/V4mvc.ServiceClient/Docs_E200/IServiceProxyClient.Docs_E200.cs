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

		ObservableCollection<Docs_E200> GetAllDocs_E200s();

		Docs_E200 GetOneDocs_E200(Guid ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveDocs_E200(ref Docs_E200 item);
		
		bool DeleteDocs_E200(ref Docs_E200 item);
		
		bool SaveDocs_E200s(ref ObservableCollection<Docs_E200> items);
		
		#endregion

	}
}
