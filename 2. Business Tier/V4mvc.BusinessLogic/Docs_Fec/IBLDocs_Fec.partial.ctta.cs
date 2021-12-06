using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Fec
	{

		#region [ Consultas ]
		ObservableCollection<Docs_Fec> GetFechasFiniquito_FuncionariosCtta(string RUT, string EMPRESA);

		Nullable<DateTime> GetNowAsDateTime();

		#endregion

		#region [ Metodos ]

		#endregion

	}
}
