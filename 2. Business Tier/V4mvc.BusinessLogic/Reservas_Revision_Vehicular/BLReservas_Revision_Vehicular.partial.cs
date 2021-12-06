using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLReservas_Revision_Vehicular
	{

		#region [ Consultas ]
		public ObservableCollection<Reservas_Revision_Vehicular> GetFechasGrid_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{
				
                var response = Repository.GetFechasGrid_AcreditacionVehicularCtta(Item);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.FECHARES_LETRA = Utils.Fec_User(item.FECHARES_LETRA, Utils.Formato_Fecha.GuionMesLetras);
                    }
                }
                return response;
            }
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Reservas_Revision_Vehicular> GetMotivoDivisionVehicular_AcreditacionVehicularCtta()
		{
			try
			{

				return Repository.GetMotivoDivisionVehicular_AcreditacionVehicularCtta();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Reservas_Revision_Vehicular> GetComboOst_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{

				return Repository.GetComboOst_Cascada_AcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Reservas_Revision_Vehicular> GetComboPatente_Cascada_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{

				return Repository.GetComboPatente_Cascada_AcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ObservableCollection<Reservas_Revision_Vehicular> GetReservasRevisionVehicularPorFecharesAcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{

				return Repository.GetReservasRevisionVehicularPorFecharesAcreditacionVehicularCtta(Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Reservas_Revision_Vehicular> GetInformeRevisionVehicularCtta(ref Reservas_Revision_Vehicular model)
		{
			try
			{
				return Repository.GetInformeRevisionVehicularCtta(ref model);
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

				return Repository.Insert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool BatchInsert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref ObservableCollection<Reservas_Revision_Vehicular> reservas)
		{
			try
			{
				bool result = true;
				using (TransactionScope tran = new TransactionScope())
				{
                    for(int i = 0; i < reservas.Count; ++i)
                    {
						var reserva = reservas[i];
						result = result && Repository.Insert_ReservasRevisionVehiculo_AcreditacionVehicularCtta(ref reserva);
					}
					tran.Complete();
				}
				return result;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool Delete_ReservasRevisionVehiculo_AcreditacionVehicularCtta(Reservas_Revision_Vehicular Item)
		{
			try
			{
                List<string> ids = Item.IDS_CANCELAR.Split(',').ToList();
                int correctos = 0;
                int incorrectos = 0;
                foreach (var id in ids)
                {

                    var result = this.Repository.Delete_ReservasRevisionVehiculo_AcreditacionVehicularCtta(new Reservas_Revision_Vehicular() { USUARIOSOL = Item.USUARIOSOL, ID = Convert.ToInt32(id) });
                    if (result)
                    {
                        correctos = correctos + 1;
                    }
                    else
                    {
                        incorrectos = incorrectos + 1;
                    }
                }
                return  true;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		#endregion

	}
}
