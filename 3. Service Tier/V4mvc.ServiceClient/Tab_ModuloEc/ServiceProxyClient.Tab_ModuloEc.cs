
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
		public IBLTab_ModuloEc BL_Tab_ModuloEc { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLTab_ModuloEc BL_Tab_ModuloEc)
		{
			this.BL_Tab_ModuloEc = BL_Tab_ModuloEc;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	