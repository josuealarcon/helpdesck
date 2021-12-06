using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Ccostos> GetAllCcostos();
		Ccostos GetOneCcostos(string EMPRESA, string CCOSTO);

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
