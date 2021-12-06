using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLBusDestino
	{

		#region [ Consultas ]
		ObservableCollection<BusDestino> GetListBusDestino_Mdte(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
