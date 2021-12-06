using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Cotizacion
	{
		#region [ Consultas ]

		ObservableCollection<Docs_Cotizacion> GetAll();

		Docs_Cotizacion GetOne(Guid? ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref Docs_Cotizacion item);

		bool Delete(ref Docs_Cotizacion item);

		bool Save(ref ObservableCollection<Docs_Cotizacion> items);

		#endregion
	}
}
