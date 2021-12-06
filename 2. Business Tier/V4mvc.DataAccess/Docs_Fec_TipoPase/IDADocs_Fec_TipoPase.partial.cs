using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Fec_TipoPase
	{

		#region [ Consultas ]
		ObservableCollection<Docs_Fec_TipoPase> GetDocsFecTipoPaseDivision(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
