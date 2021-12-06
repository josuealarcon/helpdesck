using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDARoles
	{
		
		#region [ Consultas ]
		ObservableCollection<Roles> GetAll();
		Roles GetOne(String ROL, String AREA, String PROCESO, String SUBPROCESO);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Roles Item);
		#endregion
		
	}
}
