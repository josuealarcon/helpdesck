using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATransport
	{
		
		#region [ Consultas ]
		ObservableCollection<Transport> GetAll();
        Transport GetOne(string PATENTE);
		#endregion
		#region [ Metodos ]
		bool Save(ref Transport Item);
		#endregion
		
	}
}
