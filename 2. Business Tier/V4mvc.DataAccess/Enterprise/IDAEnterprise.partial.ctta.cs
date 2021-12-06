using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAEnterprise
	{

		#region [ Consultas ]
		ObservableCollection<Enterprise> EnterpriseDatatables(Int32 iDisplayStart, Int32 iDisplayLength, String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE, String sortCOLUMN, String sortDIRECTION);
		Enterprise ContarFiltro(String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE);

		ObservableCollection<Enterprise> GetAllEnterprise_PasesCtta(string ID_EMPRESA, string OST);
		Enterprise GetEnterpriseTransport_Ctta(string DIVCOD, string PATENTE, string IDEMPRESA);
		#endregion
		#region [ Informes ]
		ObservableCollection<Enterprise> GeEnterprise_InformeConsultaRapidaCtta(Enterprise request);
		#endregion
		#region [ Metodos ]
		bool SaveEnterpriseTelefono(String TELEFONO, String IDEMPRESA);
		bool SaveNewEnterpriseCTTA(ref Enterprise Item);
		#endregion

		#region [ DashBoardCtta ]
		Enterprise GetDashBoardCtta(string IDEMPRESA);
		#endregion

		#region [ DashBoardMdte ]
		Enterprise GetDashBoardMdte(string ADMRUT);
		#endregion

	}
}
