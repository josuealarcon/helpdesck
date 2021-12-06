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
		ObservableCollection<Docs_Fec_TipoPase> GetAllDocs_Fec_TipoPase();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_Fec_TipoPase(ref Docs_Fec_TipoPase Item);
		Boolean SaveDocs_Fec_TipoPase(ref ObservableCollection<Docs_Fec_TipoPase> Items);
		#endregion
		
	}
}
