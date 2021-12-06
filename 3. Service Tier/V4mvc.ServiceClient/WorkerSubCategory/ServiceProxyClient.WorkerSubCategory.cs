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
		public IBLWorkerSubCategory BL_WorkerSubCategory { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLWorkerSubCategory BL_WorkerSubCategory)
        {
            this.BL_WorkerSubCategory = BL_WorkerSubCategory;
        }

        #endregion

        #region [ Consultas ]


		#endregion
		
		#region [ Metodos ]

		#endregion
		
	}
}
