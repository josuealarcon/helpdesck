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
		ObservableCollection<Docs_TipoPase> GetDocsTipoPaseDivision(string DIVCOD);
		ObservableCollection<Docs_TipoPase> GetFecDocsTipoPaseDivision(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
