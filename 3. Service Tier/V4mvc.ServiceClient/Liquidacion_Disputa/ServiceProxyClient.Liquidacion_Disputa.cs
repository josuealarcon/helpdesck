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
		public IBLLiquidacion_Disputa BL_Liquidacion_Disputa { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLLiquidacion_Disputa BL_Liquidacion_Disputa)
        {
            this.BL_Liquidacion_Disputa = BL_Liquidacion_Disputa;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Liquidacion_Disputa> GetAllLiquidacion_Disputa()
		{
			try
			{
				return this.BL_Liquidacion_Disputa.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Liquidacion_Disputa GetOneLiquidacion_Disputa()
		{
			try
			{
                return null;// this.BL_Liquidacion_Disputa.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveLiquidacion_Disputa(ref Liquidacion_Disputa Item)
		{
			try
			{
				return this.BL_Liquidacion_Disputa.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveLiquidacion_Disputa(ref ObservableCollection<Liquidacion_Disputa> Items)
		{
			try
			{
				return this.BL_Liquidacion_Disputa.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
