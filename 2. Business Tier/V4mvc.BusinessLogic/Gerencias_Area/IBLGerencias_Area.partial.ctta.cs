using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLGerencias_Area
	{
		#region [ Consultas ]
		ObservableCollection<Gerencias_Area> GetAreasPorGerencia(Gerencias_Area model);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
