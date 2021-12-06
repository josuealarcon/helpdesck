using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_TipoPase
	{

		#region [ Consultas ]
		ObservableCollection<Docs_TipoPase> GetDocsTipoPaseDivision(string DIVCOD);
		ObservableCollection<Docs_TipoPase> GetFecDocsTipoPaseDivision(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
