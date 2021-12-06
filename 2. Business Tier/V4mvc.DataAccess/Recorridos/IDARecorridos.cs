using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDARecorridos
	{
		#region [ Consultas ]

		ObservableCollection<Recorridos> GetAll();

		Recorridos GetOne(Int32 IDRECORRIDO);

		#endregion

		#region [ Metodos ]

		bool Save(ref Recorridos item);

		bool Delete(ref Recorridos item);

		#endregion
	}
}
