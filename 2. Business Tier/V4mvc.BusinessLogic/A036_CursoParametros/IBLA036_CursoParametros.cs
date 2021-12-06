using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLA036_CursoParametros
	{

		#region [ Consultas ]

		ObservableCollection<A036_CursoParametros> GetAll();
		A036_CursoParametros GetOne();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}