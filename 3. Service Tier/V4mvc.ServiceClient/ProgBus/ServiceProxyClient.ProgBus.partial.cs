using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]
		public ObservableCollection<ProgBus> GetAllBusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.BL_ProgBus.GetAllBusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ProgBus GetViaje_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.BL_ProgBus.GetViaje_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<ProgBus> GetAsientosReservados_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.BL_ProgBus.GetAsientosReservados_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool AsientosReservados_Delete_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.BL_ProgBus.AsientosReservados_Delete_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<ProgBus> ReservaBus_Insert_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.BL_ProgBus.ReservaBus_Insert_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ProgBus ReservaBus_Select_ValidaEmpresa_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.BL_ProgBus.ReservaBus_Select_ValidaEmpresa_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
