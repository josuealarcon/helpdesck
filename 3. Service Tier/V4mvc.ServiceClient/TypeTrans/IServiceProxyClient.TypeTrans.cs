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
		ObservableCollection<TypeTrans> GetAllTypeTrans_PasesCtta();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveTypeTrans(ref TypeTrans Item);
		Boolean SaveTypeTrans(ref ObservableCollection<TypeTrans> Items);
		#endregion
		
	}
}
