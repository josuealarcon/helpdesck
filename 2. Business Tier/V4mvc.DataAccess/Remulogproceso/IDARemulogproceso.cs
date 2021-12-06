using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
namespace V4mvc.DataAccess
{
	public partial interface IDARemulogproceso
	{
		
		#region [ Consultas ]
		ObservableCollection<Remulogproceso> GetAll();
		Remulogproceso GetOne(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Remulogproceso Item);
		#endregion
		
	}
}
