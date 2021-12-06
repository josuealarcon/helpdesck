using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAReservas_Exsico
	{

		#region [ Consultas ]

		ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoCtta(string FECHARES);
		ObservableCollection<Reservas_Exsico> GetAllTurnosExsicoCtta(string FECHARES);
		ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoEnterpriseCtta(string IDEMPRESA, string FECHARES);

		#endregion

		#region [ Métodos ]

		bool EliminarReservasExsicoCtta(string USUARIO, string LIST_ID);

		#endregion

	}
}