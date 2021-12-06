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
		ObservableCollection<OST> GetAllOST();
		OST GetOneOST(String NROOST, String IDEMPRESA);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveOST(ref OST Item);
		Boolean SaveOST(ref ObservableCollection<OST> Items);
		#endregion
		
	}
}
