using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLGerencias_Area
	{
		#region [ Consultas ]
		public ObservableCollection<Gerencias_Area> GetAreasPorGerencia(Gerencias_Area model)
		{
			try
			{
				return this.Repository.GetAreasPorGerencia(model);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
