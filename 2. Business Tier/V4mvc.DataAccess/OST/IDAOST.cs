using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAOST
	{
		
		#region [ Consultas ]
		ObservableCollection<OST> GetAll();
		OST GetOne(String NROOST, String IDEMPRESA);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref OST Item);
		#endregion
		
	}
}
