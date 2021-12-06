using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTransport_Division
	{
		
		#region [ Consultas ]
		ObservableCollection<Transport_Division> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Transport_Division Item);
		Boolean Save(ref ObservableCollection<Transport_Division> Items);
		#endregion
		
	}
}
