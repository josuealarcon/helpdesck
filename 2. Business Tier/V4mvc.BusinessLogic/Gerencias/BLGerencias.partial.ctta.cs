using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLGerencias
	{
		#region [ Consultas ]
		public ObservableCollection<Gerencias> GetGerenciasPorGGeneral(Gerencias model)
		{
			try
			{
				return this.Repository.GetGerenciasPorGGeneral(model);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
