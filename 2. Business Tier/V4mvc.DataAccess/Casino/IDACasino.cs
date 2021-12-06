using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACasino
	{

		#region [ Consultas ]

		ObservableCollection<Casino> GetAll();
		Casino GetOne();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
