using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLArea
	{
		#region [ Consultas ]
		public ObservableCollection<Area> GetAreasCheckedByPatente_VehiculosDatos(string patente)
		{
			try
			{
				return this.Repository.GetAreasCheckedByPatente_VehiculosDatos(patente);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
