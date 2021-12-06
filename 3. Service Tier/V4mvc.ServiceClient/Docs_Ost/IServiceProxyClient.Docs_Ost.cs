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

		ObservableCollection<Docs_Ost> GetAllDocs_Ost();
		Docs_Ost GetOneDocs_Ost(string OST);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveDocs_Ost(ref Docs_Ost item);		
		bool SaveDocs_Ost(ref ObservableCollection<Docs_Ost> items);

		#endregion

	}
}
