using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLBusOrigen
	{
		
		#region [ Consultas ]
		ObservableCollection<BusOrigen> GetAll();
		BusOrigen GetOne(String BUSORIGEN);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref BusOrigen Item);
		Boolean Save(ref ObservableCollection<BusOrigen> Items);
		#endregion
		
	}
}
