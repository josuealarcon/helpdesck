using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLFlotaBus
	{
		#region [ Consultas ]

		ObservableCollection<FlotaBus> GetAll();

		FlotaBus GetOne(Int32 IDFLOTA);

		#endregion

		#region [ Metodos ]

		bool Save(ref FlotaBus item);

		bool Delete(ref FlotaBus item);

		bool Save(ref ObservableCollection<FlotaBus> items);

		#endregion
	}
}
