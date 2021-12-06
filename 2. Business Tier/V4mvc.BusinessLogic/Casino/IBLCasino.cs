using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCasino
	{

		#region [ Consultas ]

		ObservableCollection<Casino> GetAll();
		Casino GetOne();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}