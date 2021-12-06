using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLBusOrigen
	{

		#region [ Consultas ]
		ObservableCollection<BusOrigen> GetListBusOrigen_Mdte(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
