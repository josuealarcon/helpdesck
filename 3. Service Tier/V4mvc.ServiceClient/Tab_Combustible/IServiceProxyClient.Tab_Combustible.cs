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
		ObservableCollection<Tab_Combustible> GetAllTab_Combustible();
		Tab_Combustible GetOneTab_Combustible(Int32 IDCOMBUSTIBLE);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveTab_Combustible(ref Tab_Combustible Item);
		Boolean SaveTab_Combustible(ref ObservableCollection<Tab_Combustible> Items);
		#endregion
		
	}
}
