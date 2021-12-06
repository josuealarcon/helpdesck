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
		ObservableCollection<Docs_Formato> GetAllDocs_Formato();
        Docs_Formato GetOneDocs_Formato(int ID_DOC_EXT);
        #endregion

        #region [ Metodos ]
        Boolean SaveDocs_Formato(ref Docs_Formato Item);
		Boolean SaveDocs_Formato(ref ObservableCollection<Docs_Formato> Items);
		#endregion
		
	}
}
