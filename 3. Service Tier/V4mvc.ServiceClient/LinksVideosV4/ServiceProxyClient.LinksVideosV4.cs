
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
		public IBLLinksVideosV4 BL_LinksVideosV4 { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLLinksVideosV4 BL_LinksVideosV4)
		{
			this.BL_LinksVideosV4 = BL_LinksVideosV4;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	