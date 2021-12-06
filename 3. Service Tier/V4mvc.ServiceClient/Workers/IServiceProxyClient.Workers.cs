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
		ObservableCollection<Workers> GetAllWorkers();
		Workers GetOneWorkers(String RUT);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveWorkers(ref Workers Item);
		Boolean SaveWorkers(ref ObservableCollection<Workers> Items);
		#endregion
		
	}
}
