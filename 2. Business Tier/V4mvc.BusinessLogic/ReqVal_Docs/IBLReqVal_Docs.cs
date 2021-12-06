using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLReqVal_Docs
	{
		
		#region [ Consultas ]
		ObservableCollection<ReqVal_Docs> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref ReqVal_Docs Item);
		Boolean Save(ref ObservableCollection<ReqVal_Docs> Items);
		#endregion
		
	}
}
