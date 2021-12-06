
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
		public IBLOSTDivLocal BL_OSTDivLocal { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLOSTDivLocal BL_OSTDivLocal)
		{
			this.BL_OSTDivLocal = BL_OSTDivLocal;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	