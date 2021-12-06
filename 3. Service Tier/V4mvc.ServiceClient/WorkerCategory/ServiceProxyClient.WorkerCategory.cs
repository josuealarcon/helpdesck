using System;
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
		public IBLWorkerCategory BL_WorkerCategory { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLWorkerCategory BL_WorkerCategory)
        {
            this.BL_WorkerCategory = BL_WorkerCategory;
        }

        #endregion

        #region [ Consultas ]


		#endregion
		
		#region [ Metodos ]

		#endregion
		
	}
}
