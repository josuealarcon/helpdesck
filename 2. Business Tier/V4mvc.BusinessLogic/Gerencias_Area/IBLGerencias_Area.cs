using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLGerencias_Area
	{
		#region [ Consultas ]

		ObservableCollection<Gerencias_Area> GetAll();

		Gerencias_Area GetOne(decimal IDAREA);

		#endregion

		#region [ Metodos ]

		bool Save(ref Gerencias_Area item);

		bool Delete(ref Gerencias_Area item);

		bool Save(ref ObservableCollection<Gerencias_Area> items);

		#endregion
	}
}
