using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
namespace V4mvc.DataAccess
{
	public partial interface IDAReservas_Revision_Vehicular
	{
		
		#region [ Consultas ]
		ObservableCollection<Reservas_Revision_Vehicular> GetAll();
		Reservas_Revision_Vehicular GetOne(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Reservas_Revision_Vehicular Item);
		#endregion
		
	}
}
