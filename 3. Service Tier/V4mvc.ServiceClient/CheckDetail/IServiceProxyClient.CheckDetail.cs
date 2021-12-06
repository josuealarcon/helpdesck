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

		ObservableCollection<CheckDetail> GetAllCheckDetails();

		CheckDetail GetOneCheckDetail(Int32 ID_CHECK);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveCheckDetail(ref CheckDetail item);
		
		bool DeleteCheckDetail(ref CheckDetail item);
		
		bool SaveCheckDetails(ref ObservableCollection<CheckDetail> items);
		
		#endregion

	}
}
