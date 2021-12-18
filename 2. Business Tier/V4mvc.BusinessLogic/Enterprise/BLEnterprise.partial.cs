using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLEnterprise
	{

		#region [ Consultas ]

		public ObservableCollection<Enterprise> EnterpriseDatatables(Int32 iDisplayStart, Int32 iDisplayLength, String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE, String sortCOLUMN, String sortDIRECTION)
		{
			try
			{
				return this.Repository.EnterpriseDatatables(iDisplayStart, iDisplayLength, searchIDEMPRESA, searchACRONIMO, searchNOMBRE, sortCOLUMN, sortDIRECTION);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Enterprise> GetAllEnterprise_PasesCtta(string ID_EMPRESA, string OST)
		{
			try
			{
				return this.Repository.GetAllEnterprise_PasesCtta(ID_EMPRESA, OST);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Enterprise ContarFiltro(String searchIDEMPRESA, String searchACRONIMO, String searchNOMBRE)
		{
			try
			{
				return this.Repository.ContarFiltro(searchIDEMPRESA, searchACRONIMO, searchNOMBRE);
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
				return this.Repository.SaveEnterpriseTelefono(TELEFONO, IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveNewEnterpriseCTTA(ref Enterprise Item)
		{
			try
			{
				return this.Repository.SaveNewEnterpriseCTTA(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ DashBoardCtta]
		public Enterprise GetDashBoardCtta(string IDEMPRESA)
		{
			try
			{
				return this.Repository.GetDashBoardCtta(IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ DashBoardMdte]
		public Enterprise GetDashBoardMdte(string ADMRUT)
		{
			try
			{
				return this.Repository.GetDashBoardMdte(ADMRUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
