
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
		public IBLParametros_V2 BL_Parametros_V2 { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLParametros_V2 BL_Parametros_V2)
		{
			this.BL_Parametros_V2 = BL_Parametros_V2;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	