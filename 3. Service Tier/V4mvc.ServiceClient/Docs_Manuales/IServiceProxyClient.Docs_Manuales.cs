using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Docs_Manuales> GetAllDocs_Manuales();
		Docs_Manuales GetOneDocs_Manual(int ID_DOC);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveDocs_Manual(ref Docs_Manuales item);
		bool SaveDocs_Manuales(ref ObservableCollection<Docs_Manuales> items);
		bool DeleteDocs_Manual(ref Docs_Manuales item);
		
		#endregion

	}
}
