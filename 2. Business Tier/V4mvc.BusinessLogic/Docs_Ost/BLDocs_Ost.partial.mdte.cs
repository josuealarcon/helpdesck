using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Ost
	{

		#region [ Consultas ]

		public Docs_Ost GetOneDocs_Ost_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL)
		{
			try
			{
				return this.Repository.GetOneDocs_Ost_Mdte(OST, MADRE, EMPRESA, NIVEL);
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
				return this.Repository.DeleteDocs_Ost(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
