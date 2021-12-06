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
		public Docs_Transport GetDocTransportsDisputa(string ID, string DIVCOD, int ID_DISPUTA)
		{
			try
			{
				return this.BL_Docs_Transport.GetDocTransportsDisputa(ID, DIVCOD, ID_DISPUTA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveTransportHistoryMaintenance(ref Docs_Transport Item)
		{
			try
			{
				return this.BL_Docs_Transport.SaveTransportHistoryMaintenance(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
