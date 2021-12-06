using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAReservas_Exsico
    {

		#region [ Consultas ]

		ObservableCollection<Reservas_Exsico> GetAll();
		Reservas_Exsico GetOne(Decimal ID);

		#endregion

		#region [ Métodos ]

		bool Save(ref Reservas_Exsico Item);

		#endregion

	}
}
