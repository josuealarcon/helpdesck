using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAA036_CursoParametros
	{

		#region [ Consultas ]

		ObservableCollection<A036_CursoParametros> GetAll();
		A036_CursoParametros GetOne();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
