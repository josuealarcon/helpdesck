using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Servicio> GetAllServicioDivisionCtta(string DIVISION);
		ObservableCollection<Servicio> GetListServiciosLocalesCasinoPermitidosAutorizaciones_Ctta();

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
