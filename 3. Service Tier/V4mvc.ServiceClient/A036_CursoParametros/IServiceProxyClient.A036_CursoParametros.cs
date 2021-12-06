using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<A036_CursoParametros> GetAllA036_CursoParametros();
		A036_CursoParametros GetOneA036_CursoParametros();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
