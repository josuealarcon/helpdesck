
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
		public IBLPoliza_Muerte BL_Poliza_Muerte { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLPoliza_Muerte BL_Poliza_Muerte)
		{
			this.BL_Poliza_Muerte = BL_Poliza_Muerte;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	