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
		ObservableCollection<Tab_TipoPase> GetAllTab_TipoPase();
		Tab_TipoPase GetOneTab_TipoPase(Int16 ID_TIPOPASE);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveTab_TipoPase(ref Tab_TipoPase Item);
		Boolean SaveTab_TipoPase(ref ObservableCollection<Tab_TipoPase> Items);
		#endregion
		
	}
}
