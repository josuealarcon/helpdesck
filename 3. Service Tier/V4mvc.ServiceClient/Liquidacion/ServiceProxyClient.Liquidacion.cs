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
		public IBLLiquidacion BL_Liquidacion { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLLiquidacion BL_Liquidacion)
        {
            this.BL_Liquidacion = BL_Liquidacion;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Liquidacion> GetAllLiquidacion()
		{
			try
			{
				return this.BL_Liquidacion.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Liquidacion GetOneLiquidacion()
		{
			try
			{
                return null;// this.BL_Liquidacion.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveLiquidacion(ref Liquidacion Item)
		{
			try
			{
				return this.BL_Liquidacion.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveLiquidacion(ref ObservableCollection<Liquidacion> Items)
		{
			try
			{
				return this.BL_Liquidacion.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
