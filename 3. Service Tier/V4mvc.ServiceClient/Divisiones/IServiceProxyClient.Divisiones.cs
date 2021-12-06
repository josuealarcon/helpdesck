using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Divisiones> GetAllDivisiones();
		Divisiones GetOneDivisiones(String DIVCOD);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDivisiones(ref Divisiones Item);
		Boolean SaveDivisiones(ref ObservableCollection<Divisiones> Items);
		#endregion
		
	}
}
