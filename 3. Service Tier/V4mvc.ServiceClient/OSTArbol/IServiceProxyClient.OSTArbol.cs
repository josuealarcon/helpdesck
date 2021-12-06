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
		ObservableCollection<OSTArbol> GetAllOSTArbol(OSTArbol oSTArbol);
		OSTArbol GetOneOSTArbol(String OST, String MADRE, String EMPRESA);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveOSTArbol(ref OSTArbol Item);
		Boolean SaveOSTArbol(ref ObservableCollection<OSTArbol> Items);
		#endregion
		
	}
}
