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
		ObservableCollection<Workers_Licencias> GetAllWorkers_Licencias();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveWorkers_Licencias(ref Workers_Licencias Item);
		Boolean SaveWorkers_Licencias(ref ObservableCollection<Workers_Licencias> Items);
		#endregion
		
	}
}
