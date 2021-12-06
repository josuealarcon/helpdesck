using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Remulogproceso> GetAllRemulogproceso();
		Remulogproceso GetOneRemulogproceso(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveRemulogproceso(ref Remulogproceso Item);
		Boolean SaveRemulogproceso(ref ObservableCollection<Remulogproceso> Items);
		#endregion
		
	}
}
