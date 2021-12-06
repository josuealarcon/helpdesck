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
		public IBLDotacion_Servicios_Ost BL_Dotacion_Servicios_Ost { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDotacion_Servicios_Ost BL_Dotacion_Servicios_Ost)
		{
			this.BL_Dotacion_Servicios_Ost = BL_Dotacion_Servicios_Ost;
		}

		#endregion

		#region [ Consultas ]

		#endregion
		
		#region [ Metodos ]

		#endregion

	}
}
