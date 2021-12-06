using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAOSTArbol
	{
		
		#region [ Consultas ]
		ObservableCollection<OSTArbol> GetAll(OSTArbol oSTArbol);
		OSTArbol GetOne(String OST, String MADRE, String EMPRESA);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref OSTArbol Item);
		#endregion
		
	}
}
