using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Tab_Tipocotizacion> GetAllTab_Tipocotizaciones();

		Tab_Tipocotizacion GetOneTab_Tipocotizacion(Int16 ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveTab_Tipocotizacion(ref Tab_Tipocotizacion item);
		
		bool DeleteTab_Tipocotizacion(ref Tab_Tipocotizacion item);
		
		bool SaveTab_Tipocotizaciones(ref ObservableCollection<Tab_Tipocotizacion> items);
		
		#endregion

	}
}
