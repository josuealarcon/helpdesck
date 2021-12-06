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
		ObservableCollection<Rol> GetRolesSearcherCtta(ref Rol model);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
