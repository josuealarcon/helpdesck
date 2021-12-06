
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
		public IBLA056_Form30_1 BL_A056_Form30_1 { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLA056_Form30_1 BL_A056_Form30_1)
		{
			this.BL_A056_Form30_1 = BL_A056_Form30_1;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	