using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLOST
	{
		
		#region [ Consultas ]
		ObservableCollection<OST> GetAll();
		OST GetOne(String NROOST, String IDEMPRESA);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref OST Item);
		Boolean Save(ref ObservableCollection<OST> Items);
		#endregion
		
	}
}
