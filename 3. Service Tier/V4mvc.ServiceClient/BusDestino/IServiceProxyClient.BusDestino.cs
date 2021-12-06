using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<BusDestino> GetAllBusDestino();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveBusDestino(ref BusDestino Item);
		Boolean SaveBusDestino(ref ObservableCollection<BusDestino> Items);
		#endregion
		
	}
}
