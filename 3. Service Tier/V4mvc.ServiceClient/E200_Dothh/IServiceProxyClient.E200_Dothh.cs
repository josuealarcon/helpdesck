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

		ObservableCollection<E200_Dothh> GetAllE200_Dothhs();

		E200_Dothh GetOneE200_Dothh(Guid ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveE200_Dothh(ref E200_Dothh item);
		
		bool DeleteE200_Dothh(ref E200_Dothh item);
		
		bool SaveE200_Dothhs(ref ObservableCollection<E200_Dothh> items);
		
		#endregion

	}
}
