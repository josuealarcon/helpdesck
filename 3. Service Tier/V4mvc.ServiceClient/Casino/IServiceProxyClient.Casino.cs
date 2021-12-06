using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Casino> GetAllCasino();
		Casino GetOneCasino();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
