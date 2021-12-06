using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Cotizacion
	{
		#region [ Consultas ]
		public ObservableCollection<Docs_Cotizacion> GetAllDocs_CotizacionCtta(ref Docs_Cotizacion docs_Cotizacion)
		{
			try
			{
				return this.Repository.GetAllDocs_CotizacionCtta(ref docs_Cotizacion);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
