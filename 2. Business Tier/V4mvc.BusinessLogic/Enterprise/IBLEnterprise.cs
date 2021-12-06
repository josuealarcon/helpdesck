using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLEnterprise
	{
		
		#region [ Consultas ]
		ObservableCollection<Enterprise> GetAll();
		Enterprise GetOne(String IDEMPRESA);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Enterprise Item);
		Boolean Save(ref ObservableCollection<Enterprise> Items);
		#endregion
		
	}
}
