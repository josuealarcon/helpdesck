using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLAAQ_Regimen
	{
		#region [ Consultas ]

		public ObservableCollection<AAQ_Regimen> GetListRegimenesPorCategoria_Mdte(int IDCATEGORIA)
		{
			try
			{
				return this.Repository.GetListRegimenesPorCategoria_Mdte(IDCATEGORIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
