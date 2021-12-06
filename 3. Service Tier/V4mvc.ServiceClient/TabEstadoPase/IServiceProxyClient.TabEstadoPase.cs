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

		ObservableCollection<TabEstadoPase> GetAllTabEstadoPases();

		TabEstadoPase GetOneTabEstadoPase(string ESTADO_PASE);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveTabEstadoPase(ref TabEstadoPase item);
		
		bool DeleteTabEstadoPase(ref TabEstadoPase item);
		
		bool SaveTabEstadoPases(ref ObservableCollection<TabEstadoPase> items);
		
		#endregion

	}
}
