using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTab_Combustible
	{
		
		#region [ Consultas ]
		ObservableCollection<Tab_Combustible> GetAll();
		Tab_Combustible GetOne(Int32 IDCOMBUSTIBLE);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Tab_Combustible Item);
		Boolean Save(ref ObservableCollection<Tab_Combustible> Items);
		#endregion
		
	}
}
