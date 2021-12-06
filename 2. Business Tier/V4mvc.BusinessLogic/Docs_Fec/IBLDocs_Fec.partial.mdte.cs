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
		ObservableCollection<Docs_Fec> GetListFechasDocumentos_Mdte();

		ObservableCollection<Docs_Fec> GetAllDocsFecSelect_mdte();
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
