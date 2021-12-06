using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLReserva_Bus
	{
		
		#region [ Consultas ]
		ObservableCollection<Reserva_Bus> GetAll();
		Reserva_Bus GetOne(Decimal IDPROG, String RUT);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Reserva_Bus Item);
		Boolean Save(ref ObservableCollection<Reserva_Bus> Items);
		#endregion
		
	}
}
