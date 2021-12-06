using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLRoles
	{
		
		#region [ Consultas ]
		ObservableCollection<Roles> GetAll();
		Roles GetOne(String ROL, String AREA, String PROCESO, String SUBPROCESO);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Roles Item);
		Boolean Save(ref ObservableCollection<Roles> Items);
		#endregion
		
	}
}
