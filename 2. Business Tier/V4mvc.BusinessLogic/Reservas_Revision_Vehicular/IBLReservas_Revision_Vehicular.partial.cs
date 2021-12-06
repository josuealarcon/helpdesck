using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLReservas_Revision_Vehicular
	{

		#region [ Consultas ]
		ObservableCollection<Reservas_Revision_Vehicular> GetFechasGrid_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item);
		ObservableCollection<Reservas_Revision_Vehicular> GetMotivoDivisionVehicular_AcreditacionVehicularCtta();
		ObservableCollection<Reservas_Revision_Vehicular> GetComboOst_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item);
		ObservableCollection<Reservas_Revision_Vehicular> GetComboPatente_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item);
		ObservableCollection<Reservas_Revision_Vehicular> GetReservasRevisionVehicularPorFecharesAcreditacionVehicularCtta(Reservas_Revision_Vehicular Item);
		ObservableCollection<Reservas_Revision_Vehicular> GetInformeRevisionVehicularCtta(ref Reservas_Revision_Vehicular model);
		#endregion

		#region [ Metodos ]
		bool Insert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref Reservas_Revision_Vehicular Item);

		bool BatchInsert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref ObservableCollection<Reservas_Revision_Vehicular> reservas);

		bool Delete_ReservasRevisionVehiculo_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item);
		#endregion

	}
}
