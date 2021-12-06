using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAGerencias
	{
		#region [ Consultas ]

		ObservableCollection<Gerencias> GetAll();

		Gerencias GetOne(Int32 IDGERENCIA);

		#endregion

		#region [ Metodos ]

		bool Save(ref Gerencias item);

		bool Delete(ref Gerencias item);

		#endregion
	}
}
