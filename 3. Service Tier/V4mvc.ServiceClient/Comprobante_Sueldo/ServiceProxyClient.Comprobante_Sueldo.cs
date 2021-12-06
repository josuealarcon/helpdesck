
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
		public IBLComprobante_Sueldo BL_Comprobante_Sueldo { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLComprobante_Sueldo BL_Comprobante_Sueldo)
		{
			this.BL_Comprobante_Sueldo = BL_Comprobante_Sueldo;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	