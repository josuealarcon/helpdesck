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
		public IBLWorkers_MotivoFiniquito BL_Workers_MotivoFiniquito { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLWorkers_MotivoFiniquito BL_Workers_MotivoFiniquito)
        {
            this.BL_Workers_MotivoFiniquito = BL_Workers_MotivoFiniquito;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Workers_MotivoFiniquito> GetAllWorkers_MotivoFiniquito()
		{
			try
			{
				return this.BL_Workers_MotivoFiniquito.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Workers_MotivoFiniquito GetOneWorkers_MotivoFiniquito()
		{
			try
			{
                return null;// this.BL_Workers_MotivoFiniquito.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveWorkers_MotivoFiniquito(ref Workers_MotivoFiniquito Item)
		{
			try
			{
				return this.BL_Workers_MotivoFiniquito.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveWorkers_MotivoFiniquito(ref ObservableCollection<Workers_MotivoFiniquito> Items)
		{
			try
			{
				return this.BL_Workers_MotivoFiniquito.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
