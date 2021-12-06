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
		public IBLLotePasesFun BL_LotePasesFun { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLLotePasesFun BL_LotePasesFun)
        {
            this.BL_LotePasesFun = BL_LotePasesFun;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<LotePasesFun> GetAllLotePasesFun()
		{
			try
			{
				return this.BL_LotePasesFun.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public LotePasesFun GetOneLotePasesFun()
		{
			try
			{
                return null;// this.BL_LotePasesFun.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveLotePasesFun(ref LotePasesFun Item)
		{
			try
			{
				return this.BL_LotePasesFun.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveLotePasesFun(ref ObservableCollection<LotePasesFun> Items)
		{
			try
			{
				return this.BL_LotePasesFun.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
