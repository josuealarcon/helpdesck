using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDepartamento
	{
		#region [ Consultas ]

		public ObservableCollection<Departamento> GetAllDepartamentos_Mdte()
		{
			try
			{
				return this.Repository.GetAllDepartamentos_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
