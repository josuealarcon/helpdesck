using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLE200_Datos
	{
		#region [ Consultas ]
		public ObservableCollection<E200_Datos> GetAllE200_DatosCtta(ref E200_Datos docs_Cotizacion)
		{
			try
			{
				return this.Repository.GetAllE200_DatosCtta(ref docs_Cotizacion);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
