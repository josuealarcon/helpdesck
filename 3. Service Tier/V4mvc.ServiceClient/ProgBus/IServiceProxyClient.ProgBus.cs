using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<ProgBus> GetAllProgBus();
		ProgBus GetOneProgBus(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveProgBus(ref ProgBus Item);
		Boolean SaveProgBus(ref ObservableCollection<ProgBus> Items);
		#endregion
		
	}
}
