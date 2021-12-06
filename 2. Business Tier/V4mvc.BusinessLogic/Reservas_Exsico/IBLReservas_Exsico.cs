using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLReservas_Exsico
	{

		#region [ Consultas ]

		ObservableCollection<Reservas_Exsico> GetAll();
		Reservas_Exsico GetOne(Decimal ID);

		#endregion

		#region [ Métodos ]

		Boolean Save(ref Reservas_Exsico Item);
		Boolean Save(ref ObservableCollection<Reservas_Exsico> Items);

		#endregion

	}
}