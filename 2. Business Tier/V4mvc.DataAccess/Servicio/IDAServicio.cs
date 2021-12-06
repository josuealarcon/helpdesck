using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAServicio
	{

		#region [ Consultas ]

		ObservableCollection<Servicio> GetAll();
		Servicio GetOne(string SERVICIO);

		#endregion

		#region [ Métodos ]

		bool Save(ref Servicio Item);

		#endregion

	}
}
