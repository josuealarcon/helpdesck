using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLGerencias
	{
		#region [ Consultas ]

		ObservableCollection<Gerencias> GetAll();

		Gerencias GetOne(Int32 IDGERENCIA);

		#endregion

		#region [ Metodos ]

		bool Save(ref Gerencias item);

		bool Delete(ref Gerencias item);

		bool Save(ref ObservableCollection<Gerencias> items);

		#endregion
	}
}
