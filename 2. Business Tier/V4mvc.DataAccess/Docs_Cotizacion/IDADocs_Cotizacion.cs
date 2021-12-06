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

		ObservableCollection<Docs_Cotizacion> GetAll();

		Docs_Cotizacion GetOne(Guid? IDEMPRESA);

		#endregion

		#region [ Metodos ]

		bool Save(ref Docs_Cotizacion item);

		bool Delete(ref Docs_Cotizacion item);

		#endregion
	}
}
