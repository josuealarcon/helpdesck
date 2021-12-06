using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAFlotaBus
	{
		#region [ Consultas ]

		ObservableCollection<FlotaBus> GetAll();

		FlotaBus GetOne(Int32 IDFLOTA);

		#endregion

		#region [ Metodos ]

		bool Save(ref FlotaBus item);

		bool Delete(ref FlotaBus item);

		#endregion
	}
}
