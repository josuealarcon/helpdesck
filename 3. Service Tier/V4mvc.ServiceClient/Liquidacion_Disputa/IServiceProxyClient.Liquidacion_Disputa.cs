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
		ObservableCollection<Liquidacion_Disputa> GetAllLiquidacion_Disputa();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveLiquidacion_Disputa(ref Liquidacion_Disputa Item);
		Boolean SaveLiquidacion_Disputa(ref ObservableCollection<Liquidacion_Disputa> Items);
		#endregion
		
	}
}
