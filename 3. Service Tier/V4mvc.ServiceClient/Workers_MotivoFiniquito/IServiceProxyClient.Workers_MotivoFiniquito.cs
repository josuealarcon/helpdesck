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
		ObservableCollection<Workers_MotivoFiniquito> GetAllWorkers_MotivoFiniquito();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveWorkers_MotivoFiniquito(ref Workers_MotivoFiniquito Item);
		Boolean SaveWorkers_MotivoFiniquito(ref ObservableCollection<Workers_MotivoFiniquito> Items);
		#endregion
		
	}
}
