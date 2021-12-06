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

		ObservableCollection<Docs_Cotizacion> GetAllDocs_Cotizacions();

		Docs_Cotizacion GetOneDocs_Cotizacion(Guid? ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveDocs_Cotizacion(ref Docs_Cotizacion item);
		
		bool DeleteDocs_Cotizacion(ref Docs_Cotizacion item);
		
		bool SaveDocs_Cotizacions(ref ObservableCollection<Docs_Cotizacion> items);
		
		#endregion

	}
}
