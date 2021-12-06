
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
		public IBLCert_No_Deuda BL_Cert_No_Deuda { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLCert_No_Deuda BL_Cert_No_Deuda)
		{
			this.BL_Cert_No_Deuda = BL_Cert_No_Deuda;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	