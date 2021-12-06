using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLRemulogproceso
	{
		
		#region [ Consultas ]
		ObservableCollection<Remulogproceso> GetAll();
		Remulogproceso GetOne(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Remulogproceso Item);
		Boolean Save(ref ObservableCollection<Remulogproceso> Items);
		#endregion
		
	}
}
