using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
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
		public IBLLotePases BL_LotePases { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLLotePases BL_LotePases)
        {
            this.BL_LotePases = BL_LotePases;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<LotePases> GetAllLotePases()
		{
			try
			{
				return this.BL_LotePases.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public LotePases GetOneLotePases()
		{
			try
			{
                return null;//this.BL_LotePases.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveLotePases(ref LotePases Item)
		{
			try
			{
				return this.BL_LotePases.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveLotePases(ref ObservableCollection<LotePases> Items)
		{
			try
			{
				return this.BL_LotePases.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
