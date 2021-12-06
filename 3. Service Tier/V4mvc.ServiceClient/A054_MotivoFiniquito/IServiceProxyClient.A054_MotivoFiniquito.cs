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
		ObservableCollection<A054_MotivoFiniquito> GetAllA054_MotivoFiniquito();
		A054_MotivoFiniquito GetOneA054_MotivoFiniquito();
		#endregion

		#region [ Metodos ]
		Boolean SaveA054_MotivoFiniquito(ref A054_MotivoFiniquito Item);
		Boolean SaveA054_MotivoFiniquito(ref ObservableCollection<A054_MotivoFiniquito> Items);
		#endregion
		
	}
}
