using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Disputa_Trans
	{

		#region [ Consultas ]
		bool SaveDisputaVehiculo(ref Docs_Disputa_Trans item);
        Docs_Disputa_Trans GetOneDocsDisputaTrans_Ctta(string PATENTE, int ID_DOC, Guid? ID, string IDEMPRESA, string USUARIO);
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
