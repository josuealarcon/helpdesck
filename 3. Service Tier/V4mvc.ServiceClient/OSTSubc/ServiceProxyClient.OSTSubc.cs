
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
		public IBLOSTSubc BL_OSTSubc { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLOSTSubc BL_OSTSubc)
		{
			this.BL_OSTSubc = BL_OSTSubc;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	