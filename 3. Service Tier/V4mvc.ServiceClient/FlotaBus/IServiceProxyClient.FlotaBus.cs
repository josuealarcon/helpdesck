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

		ObservableCollection<FlotaBus> GetAllFlotaBus();

		FlotaBus GetOneFlotaBu(Int32 IDFLOTA);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveFlotaBu(ref FlotaBus item);
		
		bool DeleteFlotaBu(ref FlotaBus item);
		
		bool SaveFlotaBus(ref ObservableCollection<FlotaBus> items);
		
		#endregion

	}
}
