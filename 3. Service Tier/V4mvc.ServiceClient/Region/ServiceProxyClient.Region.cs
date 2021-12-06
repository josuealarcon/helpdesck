
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient : IServiceProxyClient
    {

		#region [ Propiedades ]
		[Dependency]
		public IBLRegion BL_Region { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLRegion BL_Region)
		{
			this.BL_Region = BL_Region;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<Region> GetAllRegion()
		{
			try
			{
				return this.BL_Region.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	