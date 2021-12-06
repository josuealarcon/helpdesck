using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoCtta(string FECHARES);
		ObservableCollection<Reservas_Exsico> GetAllTurnosExsicoCtta(string FECHARES);
		ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoEnterpriseCtta(string IDEMPRESA, string FECHARES);

		#endregion

		#region [ Métodos ]

		Boolean EliminarReservasExsicoCtta(string USUARIO, string LIST_ID);

		#endregion

	}
}