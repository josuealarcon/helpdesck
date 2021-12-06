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
		public IBLPolizas BL_Polizas { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLPolizas BL_Polizas)
        {
            this.BL_Polizas = BL_Polizas;
        }

        #endregion

        #region [ Consultas ]

		#endregion
		
		#region [ Metodos ]

		#endregion
		
	}
}
