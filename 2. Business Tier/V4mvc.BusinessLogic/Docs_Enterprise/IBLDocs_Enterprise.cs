using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Enterprise
	{

		#region [ Consultas ]

		ObservableCollection<Docs_Enterprise> GetAll();
		Docs_Enterprise GetOne();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}