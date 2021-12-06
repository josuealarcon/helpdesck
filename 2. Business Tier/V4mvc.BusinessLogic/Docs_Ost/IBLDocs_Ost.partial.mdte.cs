using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Ost
	{

		#region [ Consultas ]

		Docs_Ost GetOneDocs_Ost_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL);

		#endregion

		#region [ Metodos ]

		bool DeleteDocs_Ost(ref Docs_Ost item);

		#endregion
	}
}
