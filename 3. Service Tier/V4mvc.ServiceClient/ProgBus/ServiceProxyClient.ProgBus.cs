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
		public IBLProgBus BL_ProgBus { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLProgBus BL_ProgBus)
        {
            this.BL_ProgBus = BL_ProgBus;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<ProgBus> GetAllProgBus()
		{
			try
			{
				return this.BL_ProgBus.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public ProgBus GetOneProgBus(Decimal IDPROG)
		{
			try
			{
				return this.BL_ProgBus.GetOne(IDPROG);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveProgBus(ref ProgBus Item)
		{
			try
			{
				return this.BL_ProgBus.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveProgBus(ref ObservableCollection<ProgBus> Items)
		{
			try
			{
				return this.BL_ProgBus.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
