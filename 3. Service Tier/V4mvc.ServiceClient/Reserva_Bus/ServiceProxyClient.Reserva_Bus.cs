using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{
		
		#region [ Propiedades ]
		[Dependency]
		public IBLReserva_Bus BL_Reserva_Bus { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLReserva_Bus BL_Reserva_Bus)
        {
            this.BL_Reserva_Bus = BL_Reserva_Bus;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Reserva_Bus> GetAllReserva_Bus()
		{
			try
			{
				return this.BL_Reserva_Bus.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Reserva_Bus GetOneReserva_Bus(Decimal IDPROG, String RUT)
		{
			try
			{
				return this.BL_Reserva_Bus.GetOne(IDPROG, RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveReserva_Bus(ref Reserva_Bus Item)
		{
			try
			{
				return this.BL_Reserva_Bus.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveReserva_Bus(ref ObservableCollection<Reserva_Bus> Items)
		{
			try
			{
				return this.BL_Reserva_Bus.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
