using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Manuales
	{
		#region [ Consultas ]

		ObservableCollection<Docs_Manuales> GetAll();
		Docs_Manuales GetOne(int ID_DOC);

		#endregion

		#region [ Metodos ]

		bool Save(ref Docs_Manuales item);
		bool Save(ref ObservableCollection<Docs_Manuales> items);
		bool Delete(ref Docs_Manuales item);

		#endregion
	}
}
