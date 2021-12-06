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
		ObservableCollection<LotePases> GetAllLotePases();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveLotePases(ref LotePases Item);
		Boolean SaveLotePases(ref ObservableCollection<LotePases> Items);
		#endregion
		
	}
}
