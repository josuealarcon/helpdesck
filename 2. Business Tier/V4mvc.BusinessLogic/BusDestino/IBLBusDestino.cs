using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLBusDestino
	{
		
		#region [ Consultas ]
		ObservableCollection<BusDestino> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref BusDestino Item);
		Boolean Save(ref ObservableCollection<BusDestino> Items);
		#endregion
		
	}
}
