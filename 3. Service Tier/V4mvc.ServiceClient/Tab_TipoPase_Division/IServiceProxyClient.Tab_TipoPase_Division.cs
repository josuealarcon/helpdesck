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
		ObservableCollection<Tab_TipoPase_Division> GetAllTab_TipoPase_Division();
		Tab_TipoPase_Division GetOneTab_TipoPase_Division(String TIPOPASE, String DIVISION);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveTab_TipoPase_Division(ref Tab_TipoPase_Division Item);
		Boolean SaveTab_TipoPase_Division(ref ObservableCollection<Tab_TipoPase_Division> Items);
		#endregion
		
	}
}
