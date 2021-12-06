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
		ObservableCollection<ReqVal_Docs> GetAllReqVal_Docs();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveReqVal_Docs(ref ReqVal_Docs Item);
		Boolean SaveReqVal_Docs(ref ObservableCollection<ReqVal_Docs> Items);
		#endregion
		
	}
}
