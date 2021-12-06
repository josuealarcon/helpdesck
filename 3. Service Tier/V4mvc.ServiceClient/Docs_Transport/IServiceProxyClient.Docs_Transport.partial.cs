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
		Docs_Transport GetDocTransportsDisputa(string ID, string DIVCOD, int ID_DISPUTA);
		Boolean SaveTransportHistoryMaintenance(ref Docs_Transport Item);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
