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
		ObservableCollection<Finiquitos> GetAllFiniquitos();
		Finiquitos GetOneFiniquitos(String Rut, String FechaCambio);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveFiniquitos(ref Finiquitos Item);
		Boolean SaveFiniquitos(ref ObservableCollection<Finiquitos> Items);
		#endregion
		
	}
}
