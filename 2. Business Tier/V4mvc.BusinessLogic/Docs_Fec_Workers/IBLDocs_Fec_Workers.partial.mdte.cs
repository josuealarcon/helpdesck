using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Fec_Workers
	{

		#region [ Consultas ]
		#endregion

		#region [ Metodos ]
		bool SaveFechasWorkersLocal_Mdte(string RUT, int ID_DOC_FEC, string DIVISION, string EMPRESA, string FECHA, string USUARIO);

		#endregion

	}
}
