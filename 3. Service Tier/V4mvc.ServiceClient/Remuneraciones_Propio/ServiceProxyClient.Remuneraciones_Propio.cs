
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
		public IBLRemuneraciones_Propio BL_Remuneraciones_Propio { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLRemuneraciones_Propio BL_Remuneraciones_Propio)
		{
			this.BL_Remuneraciones_Propio = BL_Remuneraciones_Propio;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	