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
		ObservableCollection<Tab_Reservasico> GetAllTab_Reservasico();
		Tab_Reservasico GetOneTab_Reservasico(Decimal ID);
		#endregion

		#region [ Metodos ]
		Boolean SaveTab_Reservasico(ref Tab_Reservasico Item);
		Boolean SaveTab_Reservasico(ref ObservableCollection<Tab_Reservasico> Items);
		#endregion

	}
}