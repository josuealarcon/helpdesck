using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
	{

		#region [ Consultas ]
		public ObservableCollection<Reservas_Revision_Vehicular> GetFechasGrid_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetFechasGrid_AcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Reservas_Revision_Vehicular> GetMotivoDivisionVehicular_AcreditacionVehicularCtta()
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetMotivoDivisionVehicular_AcreditacionVehicularCtta();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Reservas_Revision_Vehicular> GetComboOst_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetComboOst_Cascada_AcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Reservas_Revision_Vehicular> GetComboPatente_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetComboPatente_Cascada_AcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Reservas_Revision_Vehicular> GetReservasRevisionVehicularPorFecharesAcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetReservasRevisionVehicularPorFecharesAcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Reservas_Revision_Vehicular> GetInformeRevisionVehicularCtta(ref Reservas_Revision_Vehicular model)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetInformeRevisionVehicularCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]
		public bool Insert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref Reservas_Revision_Vehicular Item)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.Insert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool BatchInsert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref ObservableCollection<Reservas_Revision_Vehicular> reservas)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.BatchInsert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref reservas);
			}
			catch (Exception ex)
			{ throw ex; }
		}


		public bool Delete_ReservasRevisionVehiculo_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.Delete_ReservasRevisionVehiculo_AcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		#endregion

	}
}
