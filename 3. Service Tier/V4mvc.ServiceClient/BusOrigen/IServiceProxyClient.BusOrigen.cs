using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<BusOrigen> GetAllBusOrigen();
		BusOrigen GetOneBusOrigen(String BUSORIGEN);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveBusOrigen(ref BusOrigen Item);
		Boolean SaveBusOrigen(ref ObservableCollection<BusOrigen> Items);
		#endregion
		
	}
}
