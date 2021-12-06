
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
		public IBLCert_Deudas BL_Cert_Deudas { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLCert_Deudas BL_Cert_Deudas)
		{
			this.BL_Cert_Deudas = BL_Cert_Deudas;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	