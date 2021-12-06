using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLReservas_Revision_Vehicular
	{
		
		#region [ Consultas ]
		ObservableCollection<Reservas_Revision_Vehicular> GetAll();
		Reservas_Revision_Vehicular GetOne(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Reservas_Revision_Vehicular Item);
		Boolean Save(ref ObservableCollection<Reservas_Revision_Vehicular> Items);
		#endregion
		
	}
}
