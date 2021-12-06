using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLGerencias_General
	{
		#region [ Consultas ]
		public ObservableCollection<Gerencias_General> GetGGeneralPorDivision(Gerencias_General gerencias_General)
		{
			try
			{
				return this.Repository.GetGGeneralPorDivision(gerencias_General);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
