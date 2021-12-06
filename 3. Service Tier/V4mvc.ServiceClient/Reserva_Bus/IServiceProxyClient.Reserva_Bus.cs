using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Reserva_Bus> GetAllReserva_Bus();
		Reserva_Bus GetOneReserva_Bus(Decimal IDPROG, String RUT);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveReserva_Bus(ref Reserva_Bus Item);
		Boolean SaveReserva_Bus(ref ObservableCollection<Reserva_Bus> Items);
		#endregion
		
	}
}
