using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAReserva_Bus
	{
		
		#region [ Consultas ]
		ObservableCollection<Reserva_Bus> GetAll();
		Reserva_Bus GetOne(Decimal IDPROG, String RUT);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Reserva_Bus Item);
		#endregion
		
	}
}
