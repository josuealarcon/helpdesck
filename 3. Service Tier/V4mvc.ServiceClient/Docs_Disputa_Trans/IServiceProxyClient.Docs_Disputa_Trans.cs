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
		ObservableCollection<Docs_Disputa_Trans> GetAllDocs_Disputa_Trans();
		Docs_Disputa_Trans GetOneDocs_Disputa_Trans(Int32 ID_DISPUTA);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Disputa_Trans(ref Docs_Disputa_Trans Item);
		Boolean SaveDocs_Disputa_Trans(ref ObservableCollection<Docs_Disputa_Trans> Items);
		#endregion
		
	}
}
