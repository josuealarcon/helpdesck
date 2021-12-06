using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTab_Traccion
	{
		
		#region [ Consultas ]
		ObservableCollection<Tab_Traccion> GetAll();
		Tab_Traccion GetOne(Int32 IDTRACCION);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Tab_Traccion Item);
		Boolean Save(ref ObservableCollection<Tab_Traccion> Items);
		#endregion
		
	}
}
