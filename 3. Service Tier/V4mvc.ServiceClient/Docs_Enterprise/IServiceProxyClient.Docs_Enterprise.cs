using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Docs_Enterprise> GetAllDocs_Enterprise();
		Docs_Enterprise GetOneDocs_Enterprise();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
