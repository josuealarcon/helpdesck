using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLRecorridos
	{
		#region [ Consultas ]

		ObservableCollection<Recorridos> GetAll();

		Recorridos GetOne(Int32 IDRECORRIDO);

		#endregion

		#region [ Metodos ]

		bool Save(ref Recorridos item);

		bool Delete(ref Recorridos item);

		bool Save(ref ObservableCollection<Recorridos> items);

		#endregion
	}
}
