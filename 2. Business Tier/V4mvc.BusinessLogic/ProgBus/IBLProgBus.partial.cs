using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLProgBus
	{

		#region [ Consultas ]
		ObservableCollection<ProgBus> GetAllBusesReservaCtta(ProgBus Item);
		ProgBus GetViaje_BusesReservaCtta(ProgBus Item);
		ObservableCollection<ProgBus> GetAsientosReservados_BusesReservaCtta(ProgBus Item);
		bool AsientosReservados_Delete_BusesReservaCtta(ProgBus Item);
		ObservableCollection<ProgBus> ReservaBus_Insert_BusesReservaCtta(ProgBus Item);
		ProgBus ReservaBus_Select_ValidaEmpresa_BusesReservaCtta(ProgBus Item);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
