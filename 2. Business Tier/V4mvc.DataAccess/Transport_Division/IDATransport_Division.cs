using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATransport_Division
	{
		
		#region [ Consultas ]
		ObservableCollection<Transport_Division> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Transport_Division Item);
		#endregion
		
	}
}
