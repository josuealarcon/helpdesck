using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLA025Area
	{
		#region [ Consultas ]
		public ObservableCollection<A025Area> GetAllAreas_Mdte()
        {
			try
			{
				return this.Repository.GetAllAreas_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
