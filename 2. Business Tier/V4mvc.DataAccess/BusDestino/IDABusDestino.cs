
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDABusDestino
	{
		
		#region [ Consultas ]
		ObservableCollection<BusDestino> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref BusDestino Item);
		#endregion
		
	}
}
