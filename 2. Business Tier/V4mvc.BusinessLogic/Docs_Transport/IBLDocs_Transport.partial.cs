using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Transport
	{

		#region [ Consultas ]
		Docs_Transport GetDocTransportsDisputa(string ID, string DIVCOD, int ID_DISPUTA);
		Boolean SaveTransportHistoryMaintenance(ref Docs_Transport Item);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
