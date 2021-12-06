using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAGerencias_Area
	{
		#region [ Consultas ]

		ObservableCollection<Gerencias_Area> GetAll();

		Gerencias_Area GetOne(decimal IDAREA);

		#endregion

		#region [ Metodos ]

		bool Save(ref Gerencias_Area item);

		bool Delete(ref Gerencias_Area item);

		#endregion
	}
}
