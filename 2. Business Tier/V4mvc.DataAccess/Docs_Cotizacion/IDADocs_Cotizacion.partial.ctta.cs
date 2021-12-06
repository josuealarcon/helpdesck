using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Cotizacion
	{
		#region [ Consultas ]
		ObservableCollection<Docs_Cotizacion> GetAllDocs_CotizacionCtta(ref Docs_Cotizacion docs_Cotizacion);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
