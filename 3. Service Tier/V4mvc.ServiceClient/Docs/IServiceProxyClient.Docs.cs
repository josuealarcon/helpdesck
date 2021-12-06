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
		ObservableCollection<Docs> GetAllDocs();
        Docs GetOneDocs(int ID_DOC);
        #endregion

        #region [ Metodos ]
        Boolean SaveDocs(ref Docs Item);
		Boolean SaveDocs(ref ObservableCollection<Docs> Items);
		#endregion
		
	}
}
