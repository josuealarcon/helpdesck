using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Reservas_Revision_Vehicular> GetAllReservas_Revision_Vehicular();
		Reservas_Revision_Vehicular GetOneReservas_Revision_Vehicular(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveReservas_Revision_Vehicular(ref Reservas_Revision_Vehicular Item);
		Boolean SaveReservas_Revision_Vehicular(ref ObservableCollection<Reservas_Revision_Vehicular> Items);
		#endregion
		
	}
}
