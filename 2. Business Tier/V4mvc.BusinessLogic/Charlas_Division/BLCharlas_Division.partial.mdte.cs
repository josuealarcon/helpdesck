using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCharlas_Division
	{
		#region [ Consultas ]

		public ObservableCollection<Charlas_Division> GetListDivisionesCharlas_Mdte(int IDCHARLA)
		{
			try
			{
				return this.Repository.GetListDivisionesCharlas_Mdte(IDCHARLA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
