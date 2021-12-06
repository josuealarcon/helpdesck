using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTransport_Division_Pases
	{
		
		#region [ Consultas ]
		ObservableCollection<Transport_Division_Pases> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Transport_Division_Pases Item);
		Boolean Save(ref ObservableCollection<Transport_Division_Pases> Items);
		#endregion
		
	}
}
