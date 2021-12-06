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
		ObservableCollection<Motivo_Finiquito> GetAllMotivo_Finiquito();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveMotivo_Finiquito(ref Motivo_Finiquito Item);
		Boolean SaveMotivo_Finiquito(ref ObservableCollection<Motivo_Finiquito> Items);
		#endregion
		
	}
}
