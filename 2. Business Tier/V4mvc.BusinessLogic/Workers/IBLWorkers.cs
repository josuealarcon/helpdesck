using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkers
	{
		
		#region [ Consultas ]
		ObservableCollection<Workers> GetAll();
		Workers GetOne(String RUT);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Workers Item);
		Boolean Save(ref ObservableCollection<Workers> Items);
		#endregion
		
	}
}
