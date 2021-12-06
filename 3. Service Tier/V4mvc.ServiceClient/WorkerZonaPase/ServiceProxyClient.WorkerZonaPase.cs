
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
		public IBLWorkerZonaPase BL_WorkerZonaPase { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLWorkerZonaPase BL_WorkerZonaPase)
		{
			this.BL_WorkerZonaPase = BL_WorkerZonaPase;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	