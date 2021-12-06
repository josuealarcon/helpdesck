using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Transport_Division> GetAllTransport_Division();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveTransport_Division(ref Transport_Division Item);
		Boolean SaveTransport_Division(ref ObservableCollection<Transport_Division> Items);
		#endregion
		
	}
}
