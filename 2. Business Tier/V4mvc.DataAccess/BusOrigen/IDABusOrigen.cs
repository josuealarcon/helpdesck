using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDABusOrigen
	{
		
		#region [ Consultas ]
		ObservableCollection<BusOrigen> GetAll();
		BusOrigen GetOne(String BUSORIGEN);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref BusOrigen Item);
		#endregion
		
	}
}
