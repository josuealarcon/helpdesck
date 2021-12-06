using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLArea
	{
		#region [ Consultas ]
		ObservableCollection<Area> GetAreasCheckedByPatente_VehiculosDatos(string patente);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
