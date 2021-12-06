
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
		public IBLPoliza_Salud BL_Poliza_Salud { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLPoliza_Salud BL_Poliza_Salud)
		{
			this.BL_Poliza_Salud = BL_Poliza_Salud;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	