using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Ost
	{
		#region [ Consultas ]

		Docs_Ost GetOneDocs_Ost_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL);

		#endregion

		#region [ Metodos ]

		bool DeleteDocs_Ost(ref Docs_Ost item);

		#endregion
	}
}
