

using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDABusDestino
	{

		#region [ Consultas ]
		ObservableCollection<BusDestino> GetListBusDestino_Mdte(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
