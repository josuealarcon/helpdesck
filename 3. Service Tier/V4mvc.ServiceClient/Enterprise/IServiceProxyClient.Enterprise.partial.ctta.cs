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
		ObservableCollection<Enterprise> GetEnterpriseDatatables(Int32 iDisplayStart, Int32 iDisplayLength, String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE, String sortCOLUMN, String sortDIRECTION);
		Enterprise ContarFiltroEnterprise(String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE);

		ObservableCollection<Enterprise> GetAllEnterprise_PasesCtta(string ID_EMPRESA, string OST);
		#endregion

		#region [ Metodos ]
		bool SaveEnterpriseTelefono(String TELEFONO, String IDEMPRESA);
		bool SaveNewEnterpriseCTTA(ref Enterprise Item);
        Enterprise GetEnterpriseTransport_Ctta(string DIVCOD, string PATENTE, string IDEMPRESA);
        #endregion

        #region [ DashBoardCtta ]
        Enterprise GetDashBoardCtta(string IDEMPRESA);
		#endregion

		#region [ DashBoardMdte ]
		Enterprise GetDashBoardMdte(string ADMRUT);
		#endregion

	}
}
