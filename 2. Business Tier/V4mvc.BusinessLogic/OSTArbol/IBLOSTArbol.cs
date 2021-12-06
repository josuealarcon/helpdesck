using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLOSTArbol
	{
		
		#region [ Consultas ]
		ObservableCollection<OSTArbol> GetAll(OSTArbol oSTArbol);
		OSTArbol GetOne(String OST, String MADRE, String EMPRESA);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref OSTArbol Item);
		Boolean Save(ref ObservableCollection<OSTArbol> Items);
		#endregion
		
	}
}
