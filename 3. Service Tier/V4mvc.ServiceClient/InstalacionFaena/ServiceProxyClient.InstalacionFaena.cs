
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
		public IBLInstalacionFaena BL_InstalacionFaena { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLInstalacionFaena BL_InstalacionFaena)
		{
			this.BL_InstalacionFaena = BL_InstalacionFaena;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	