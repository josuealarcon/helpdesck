using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Disputa_Trans
	{

		#region [ Consultas ]
		Docs_Disputa_Trans GetDocumentacionDisputaTranspotCtta(string PATENTE, string DIVCOD, int ID_DOC, Guid? ID, string COMUN_DIV, string IDEMPRESA);
        Docs_Disputa_Trans GetOneDocsDisputaTrans_Ctta(string PATENTE, int ID_DOC, Guid? ID, string IDEMPRESA, string USUARIO);

        bool SaveDisputaVehiculo(ref Docs_Disputa_Trans item);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
