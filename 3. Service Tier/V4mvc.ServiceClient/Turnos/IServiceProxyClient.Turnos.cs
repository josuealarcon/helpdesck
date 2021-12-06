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
		ObservableCollection<Turnos> GetAllTurnos();
		#endregion

		#region [ Metodos ]
		Boolean SaveTurnos(ref Turnos Item);
		Boolean SaveTurnos(ref ObservableCollection<Turnos> Items);
		#endregion
		
	}
}
