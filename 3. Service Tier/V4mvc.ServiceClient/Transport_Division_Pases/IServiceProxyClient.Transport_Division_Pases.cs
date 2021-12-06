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
		ObservableCollection<Transport_Division_Pases> GetAllTransport_Division_Pases();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveTransport_Division_Pases(ref Transport_Division_Pases Item);
		Boolean SaveTransport_Division_Pases(ref ObservableCollection<Transport_Division_Pases> Items);
		#endregion
		
	}
}
