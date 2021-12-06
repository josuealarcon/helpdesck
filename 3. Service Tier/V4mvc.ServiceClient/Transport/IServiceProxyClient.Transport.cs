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
		ObservableCollection<Transport> GetAllTransport();
        Transport GetOneTransport(string PATENTE);
        #endregion

        #region [ Metodos ]
        Boolean SaveTransport(ref Transport Item);
		Boolean SaveTransport(ref ObservableCollection<Transport> Items);
		#endregion
		
	}
}
