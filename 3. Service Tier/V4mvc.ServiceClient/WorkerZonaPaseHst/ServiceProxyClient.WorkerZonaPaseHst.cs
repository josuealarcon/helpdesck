
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
		public IBLWorkerZonaPaseHst BL_WorkerZonaPaseHst { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLWorkerZonaPaseHst BL_WorkerZonaPaseHst)
		{
			this.BL_WorkerZonaPaseHst = BL_WorkerZonaPaseHst;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	