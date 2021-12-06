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

		ObservableCollection<OSTCombust> GetAllOSTCombusts();
		OSTCombust GetOneOSTCombust(string NROOST);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveOSTCombust(ref OSTCombust item);		
		bool SaveOSTCombusts(ref ObservableCollection<OSTCombust> items);
		
		#endregion

	}
}
