using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTab_Tipocotizacion
	{
		#region [ Consultas ]

		ObservableCollection<Tab_Tipocotizacion> GetAll();

		Tab_Tipocotizacion GetOne(Int16 ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref Tab_Tipocotizacion item);

		bool Delete(ref Tab_Tipocotizacion item);

		bool Save(ref ObservableCollection<Tab_Tipocotizacion> items);

		#endregion
	}
}
