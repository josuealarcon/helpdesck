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
		public IBLWorkers BL_Workers { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLWorkers BL_Workers)
        {
            this.BL_Workers = BL_Workers;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Workers> GetAllWorkers()
		{
			try
			{
				return this.BL_Workers.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Workers GetOneWorkers(String RUT)
		{
			try
			{
				if (RUT == null) { return null; }
				return this.BL_Workers.GetOne(RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveWorkers(ref Workers Item)
		{
			try
			{
				return this.BL_Workers.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveWorkers(ref ObservableCollection<Workers> Items)
		{
			try
			{
				return this.BL_Workers.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
