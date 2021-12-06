using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACcostos
	{

		#region [ Consultas ]

		ObservableCollection<Ccostos> GetAll();
		Ccostos GetOne(string EMPRESA, string CCOSTO);

		#endregion

		#region [ Métodos ]

		bool Save(ref Ccostos Item);

		#endregion

	}
}
