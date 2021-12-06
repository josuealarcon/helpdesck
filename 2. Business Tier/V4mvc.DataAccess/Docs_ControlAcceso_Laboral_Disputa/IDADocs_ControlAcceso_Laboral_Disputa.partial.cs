using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_ControlAcceso_Laboral_Disputa
	{

		#region [ Consultas ]
		Docs_ControlAcceso_Laboral_Disputa GetDocs_ControlAcceso_Laboral_Disputa_Top(string RUT, string FECHA_INI, string FECHA_FIN, string EMPRESA, int ID_DOC, Guid ID);
		Docs_ControlAcceso_Laboral_Disputa GetDocs_ControlAcceso_Laboral_Disputa_EstadoNo(int ID_DISPUTA);
		bool Docs_ControlAcceso_Laboral_Disputa_Delete_EstadoNo(int ID_DISPUTA);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
