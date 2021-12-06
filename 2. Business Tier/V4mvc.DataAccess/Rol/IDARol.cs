using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDARol
	{
		
		#region [ Consultas ]
		ObservableCollection<Rol> GetAll();
		Rol GetOne(Int32 ID_ROL);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Rol Item);
		#endregion
		
	}
}
