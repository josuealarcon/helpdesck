using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLArea
	{
		#region [ Consultas ]

		ObservableCollection<Area> GetAll();

		Area GetOne(string AREA);

		#endregion

		#region [ Metodos ]

		bool Save(ref Area item);

		bool Delete(ref Area item);

		bool Save(ref ObservableCollection<Area> items);

		#endregion
	}
}
