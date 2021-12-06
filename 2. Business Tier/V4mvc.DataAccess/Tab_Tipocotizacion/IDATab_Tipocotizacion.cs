using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATab_Tipocotizacion
	{
		#region [ Consultas ]

		ObservableCollection<Tab_Tipocotizacion> GetAll();

		Tab_Tipocotizacion GetOne(Int16 ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref Tab_Tipocotizacion item);

		bool Delete(ref Tab_Tipocotizacion item);

		#endregion
	}
}
