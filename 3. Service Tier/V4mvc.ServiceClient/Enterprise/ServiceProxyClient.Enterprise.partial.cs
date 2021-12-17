using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public ObservableCollection<Enterprise> GetEnterpriseDatatables(Int32 iDisplayStart, Int32 iDisplayLength, String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE, String sortCOLUMN, String sortDIRECTION)
		{
			try
			{
				return this.BL_Enterprise.EnterpriseDatatables(iDisplayStart,iDisplayLength,searchIDEMPRESA,searchACRONIMO,searchNOMBRE,sortCOLUMN,sortDIRECTION);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Enterprise> GetAllEnterprise_PasesCtta(string ID_EMPRESA, string OST)
		{
			try
			{
				return this.BL_Enterprise.GetAllEnterprise_PasesCtta(ID_EMPRESA, OST);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Enterprise ContarFiltroEnterprise(String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE)
		{
			try
			{
				return this.BL_Enterprise.ContarFiltro(searchIDEMPRESA, searchACRONIMO, searchNOMBRE);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool SaveEnterpriseTelefono(String TELEFONO, String IDEMPRESA)
		{
			try
			{
				return this.BL_Enterprise.SaveEnterpriseTelefono(TELEFONO, IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveNewEnterpriseCTTA(ref Enterprise Item)
		{
			try
			{
				return this.BL_Enterprise.SaveNewEnterpriseCTTA(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ DashBoardCtta ]
		public Enterprise GetDashBoardCtta(string IDEMPRESA)
		{
			try
			{
				return this.BL_Enterprise.GetDashBoardCtta(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ DashBoardMdte ]
		public Enterprise GetDashBoardMdte(string ADMRUT)
		{
			try
			{
				return this.BL_Enterprise.GetDashBoardMdte(ADMRUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
