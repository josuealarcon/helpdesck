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
		public IBLBusOrigen BL_BusOrigen { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLBusOrigen BL_BusOrigen)
        {
            this.BL_BusOrigen = BL_BusOrigen;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<BusOrigen> GetAllBusOrigen()
		{
			try
			{
				return this.BL_BusOrigen.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public BusOrigen GetOneBusOrigen(String BUSORIGEN)
		{
			try
			{
				return this.BL_BusOrigen.GetOne(BUSORIGEN);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveBusOrigen(ref BusOrigen Item)
		{
			try
			{
				return this.BL_BusOrigen.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveBusOrigen(ref ObservableCollection<BusOrigen> Items)
		{
			try
			{
				return this.BL_BusOrigen.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
