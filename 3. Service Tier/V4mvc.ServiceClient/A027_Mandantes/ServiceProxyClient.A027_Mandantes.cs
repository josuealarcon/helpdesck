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
		public IBLA027_Mandantes BL_A027_Mandantes { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLA027_Mandantes BL_A027_Mandantes)
		{
			this.BL_A027_Mandantes = BL_A027_Mandantes;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Métodos ]

		#endregion

	}
}