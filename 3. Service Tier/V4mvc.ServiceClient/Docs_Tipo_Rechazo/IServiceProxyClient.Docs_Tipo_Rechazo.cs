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
		ObservableCollection<Docs_Tipo_Rechazo> GetAllDocs_Tipo_Rechazo();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Tipo_Rechazo(ref Docs_Tipo_Rechazo Item);
		Boolean SaveDocs_Tipo_Rechazo(ref ObservableCollection<Docs_Tipo_Rechazo> Items);
		#endregion
		
	}
}
