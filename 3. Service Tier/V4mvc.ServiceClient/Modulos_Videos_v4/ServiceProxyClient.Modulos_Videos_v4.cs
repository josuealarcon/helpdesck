
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
		public IBLModulos_Videos_v4 BL_Modulos_Videos_v4 { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLModulos_Videos_v4 BL_Modulos_Videos_v4)
		{
			this.BL_Modulos_Videos_v4 = BL_Modulos_Videos_v4;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	