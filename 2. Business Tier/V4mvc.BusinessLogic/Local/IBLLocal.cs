using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLocal
	{
		
		#region [ Consultas ]
		ObservableCollection<Local> GetAll();
		Local GetOne(String LOCAL, String EMPRESAL, String LOCALL);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Local Item);
		Boolean Save(ref ObservableCollection<Local> Items);
		#endregion
		
	}
}
