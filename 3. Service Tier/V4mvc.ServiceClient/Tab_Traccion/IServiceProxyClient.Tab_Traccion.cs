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
		ObservableCollection<Tab_Traccion> GetAllTab_Traccion();
		Tab_Traccion GetOneTab_Traccion(Int32 IDTRACCION);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveTab_Traccion(ref Tab_Traccion Item);
		Boolean SaveTab_Traccion(ref ObservableCollection<Tab_Traccion> Items);
		#endregion
		
	}
}
