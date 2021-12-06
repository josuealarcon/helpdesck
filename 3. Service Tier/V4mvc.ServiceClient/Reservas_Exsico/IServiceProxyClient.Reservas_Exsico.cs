using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Reservas_Exsico> GetAllReservas_Exsico();
		Reservas_Exsico GetOneReservas_Exsico(Decimal ID);

		#endregion

		#region [ Métodos ]

		Boolean SaveReservas_Exsico(ref Reservas_Exsico Item);
		Boolean SaveReservas_Exsico(ref ObservableCollection<Reservas_Exsico> Items);

		#endregion

	}
}