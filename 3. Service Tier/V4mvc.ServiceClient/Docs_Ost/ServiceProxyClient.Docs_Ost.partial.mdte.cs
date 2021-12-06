using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public Docs_Ost GetOneDocs_Ost_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL)
		{
			try
			{
				return this.BL_Docs_Ost.GetOneDocs_Ost_Mdte(OST, MADRE, EMPRESA, NIVEL);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool DeleteDocs_Ost(ref Docs_Ost item)
		{
			try
			{
				return this.BL_Docs_Ost.DeleteDocs_Ost(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
