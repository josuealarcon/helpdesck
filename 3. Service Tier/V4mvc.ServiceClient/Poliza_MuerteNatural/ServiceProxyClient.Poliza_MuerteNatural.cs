
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
		public IBLPoliza_MuerteNatural BL_Poliza_MuerteNatural { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLPoliza_MuerteNatural BL_Poliza_MuerteNatural)
		{
			this.BL_Poliza_MuerteNatural = BL_Poliza_MuerteNatural;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	