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
		public IBLA054_MotivoFiniquito BL_A054_MotivoFiniquito { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLA054_MotivoFiniquito BL_A054_MotivoFiniquito)
        {
            this.BL_A054_MotivoFiniquito = BL_A054_MotivoFiniquito;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<A054_MotivoFiniquito> GetAllA054_MotivoFiniquito()
		{
			try
			{
				return this.BL_A054_MotivoFiniquito.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public A054_MotivoFiniquito GetOneA054_MotivoFiniquito()
		{
			try
			{
                return null;// this.BL_A054_MotivoFiniquito.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveA054_MotivoFiniquito(ref A054_MotivoFiniquito Item)
		{
			try
			{
				return this.BL_A054_MotivoFiniquito.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveA054_MotivoFiniquito(ref ObservableCollection<A054_MotivoFiniquito> Items)
		{
			try
			{
				return this.BL_A054_MotivoFiniquito.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
