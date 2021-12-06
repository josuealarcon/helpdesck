using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLServicio
	{

		#region [ Consultas ]

		ObservableCollection<Servicio> GetAll();
		Servicio GetOne(string SERVICIO);

		#endregion

		#region [ Métodos ]

		Boolean Save(ref Servicio Item);
		Boolean Save(ref ObservableCollection<Servicio> Items);

		#endregion

	}
}
