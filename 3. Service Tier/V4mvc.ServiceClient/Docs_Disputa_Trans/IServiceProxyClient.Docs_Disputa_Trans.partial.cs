using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		bool SaveDisputaVehiculo(ref Docs_Disputa_Trans Item);
        Docs_Disputa_Trans GetOneDocsDisputaTrans_Ctta(string PATENTE, int ID_DOC, Guid? ID, string IDEMPRESA, string USUARIO);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
