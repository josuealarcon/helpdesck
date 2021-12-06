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
		public IBLBusDestino BL_BusDestino { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLBusDestino BL_BusDestino)
        {
            this.BL_BusDestino = BL_BusDestino;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<BusDestino> GetAllBusDestino()
		{
			try
			{
				return this.BL_BusDestino.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public BusDestino GetOneBusDestino()
		{
			try
			{
                return null;//this.BL_BusDestino.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveBusDestino(ref BusDestino Item)
		{
			try
			{
				return this.BL_BusDestino.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveBusDestino(ref ObservableCollection<BusDestino> Items)
		{
			try
			{
				return this.BL_BusDestino.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
