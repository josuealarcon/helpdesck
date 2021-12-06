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
		string getFechaWLocal(string RUT, int ID_DOC_FEC, string EMPRESA);
		#endregion

		#region [ Metodos ]
		bool setFechaWLocal(string RUT, int ID_DOC_FEC, string DIV, string EMPRESA, string FECHA, string USUARIO);
		bool setFechaEmpresa(int ID_DOC_FEC, string EMPRESA, string FECHA);
		#endregion

	}
}
