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
		public IBLOSTAdmin BL_OSTAdmin { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLOSTAdmin BL_OSTAdmin)
		{
			this.BL_OSTAdmin = BL_OSTAdmin;
		}

		#endregion

		#region [ Consultas ]

		#endregion
		
		#region [ Metodos ]

		#endregion
	}
}
