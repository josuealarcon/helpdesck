using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLRol
	{
		
		#region [ Consultas ]
		ObservableCollection<Rol> GetAll();
		Rol GetOne(Int32 ID_ROL);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Rol Item);
		Boolean Save(ref ObservableCollection<Rol> Items);
		#endregion
		
	}
}
