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
		ObservableCollection<Gerencias_Area> GetAreasPorGerencia(Gerencias_Area model);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
