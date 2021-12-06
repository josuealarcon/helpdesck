using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLProgBus
	{

		#region [ Consultas ]
		public ObservableCollection<ProgBus> GetAllBusesReservaCtta(ProgBus Item)
		{
			try
			{
				var response = Repository.GetAllBusesReservaCtta(Item);

				if (response != null)
				{
					foreach (var item in response)
					{
						item.FECHA = Utils.Fec_User(item.FECHA, Utils.Formato_Fecha.GuionMesLetras);
					}
				}
				return response;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ProgBus GetViaje_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.Repository.GetViaje_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<ProgBus> GetAsientosReservados_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.Repository.GetAsientosReservados_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool AsientosReservados_Delete_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.Repository.AsientosReservados_Delete_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<ProgBus> ReservaBus_Insert_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				ObservableCollection<ProgBus> resultadosReservas = new ObservableCollection<ProgBus>();
				ProgBus reserva = new ProgBus();
				List<string> recorridos = Item.RECORRIDOS.Split(',').ToList();
				List<string> funcionarios = Item.FUNCIONARIOS.Split(',').ToList();
				int correctos = 0;
				int incorrectos = 0;
				foreach (var recorrido in recorridos)
                {
                    foreach (var funcionario in funcionarios)
                    {

						string[] partes = funcionario.Split('-');
						
						reserva = this.Repository.GetReservaBuses(Convert.ToInt32(recorrido), partes[0], Item.EMPRESA, partes[1], Item.USUARIO);
						resultadosReservas.Add(reserva);
                        if (reserva.EXITOSO)
                        {
                            correctos = correctos + 1;
                        }
                        else
                        {
                            incorrectos = incorrectos + 1;
                        }
                    }
				}
				return resultadosReservas; 
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ProgBus ReservaBus_Select_ValidaEmpresa_BusesReservaCtta(ProgBus Item)
		{
			try
			{
				return this.Repository.ReservaBus_Select_ValidaEmpresa_BusesReservaCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
