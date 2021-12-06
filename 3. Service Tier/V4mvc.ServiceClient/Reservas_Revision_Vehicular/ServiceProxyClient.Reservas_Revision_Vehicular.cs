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
		public IBLReservas_Revision_Vehicular BL_Reservas_Revision_Vehicular { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLReservas_Revision_Vehicular BL_Reservas_Revision_Vehicular)
        {
            this.BL_Reservas_Revision_Vehicular = BL_Reservas_Revision_Vehicular;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Reservas_Revision_Vehicular> GetAllReservas_Revision_Vehicular()
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Reservas_Revision_Vehicular GetOneReservas_Revision_Vehicular(Decimal IDPROG)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.GetOne(IDPROG);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveReservas_Revision_Vehicular(ref Reservas_Revision_Vehicular Item)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveReservas_Revision_Vehicular(ref ObservableCollection<Reservas_Revision_Vehicular> Items)
		{
			try
			{
				return this.BL_Reservas_Revision_Vehicular.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
