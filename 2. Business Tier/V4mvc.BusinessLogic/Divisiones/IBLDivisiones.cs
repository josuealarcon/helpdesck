using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDivisiones
	{
		
		#region [ Consultas ]
		ObservableCollection<Divisiones> GetAll();
		Divisiones GetOne(String DIVCOD);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Divisiones Item);
		Boolean Save(ref ObservableCollection<Divisiones> Items);
		#endregion
		
	}
}
