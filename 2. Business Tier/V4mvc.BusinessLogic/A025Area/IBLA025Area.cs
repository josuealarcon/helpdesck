using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLA025Area
	{
		#region [ Consultas ]

		ObservableCollection<A025Area> GetAll();

		A025Area GetOne(Int32 ID_AREA);

		#endregion

		#region [ Metodos ]

		bool Save(ref A025Area item);

		bool Delete(ref A025Area item);

		bool Save(ref ObservableCollection<A025Area> items);

		#endregion
	}
}
