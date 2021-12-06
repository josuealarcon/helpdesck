using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Servicio> GetAllServicio();
		Servicio GetOneServicio(string SERVICIO);

		#endregion

		#region [ Métodos ]

		Boolean SaveServicio(ref Servicio Item);
		Boolean SaveServicio(ref ObservableCollection<Servicio> Items);

		#endregion

	}
}
