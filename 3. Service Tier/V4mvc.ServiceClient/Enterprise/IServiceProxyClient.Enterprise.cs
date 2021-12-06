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
		ObservableCollection<Enterprise> GetAllEnterprise();
		Enterprise GetOneEnterprise(String IDEMPRESA);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveEnterprise(ref Enterprise Item);
		Boolean SaveEnterprise(ref ObservableCollection<Enterprise> Items);
		#endregion
		
	}
}
