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
		public IBLSector BL_Sector { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLSector BL_Sector)
		{
			this.BL_Sector = BL_Sector;
		}

		#endregion

		#region [ Consultas ]

		#endregion
		
		#region [ Metodos ]

		#endregion
	}
}
