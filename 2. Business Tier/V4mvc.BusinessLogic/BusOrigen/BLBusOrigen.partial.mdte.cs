using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLBusOrigen
	{

		#region [ Consultas ]
		public ObservableCollection<BusOrigen> GetListBusOrigen_Mdte(string DIVCOD)
        {
			try
			{
				return this.Repository.GetListBusOrigen_Mdte(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
