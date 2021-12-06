
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
		public IBLA056_Form30_1_Det BL_A056_Form30_1_Det { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLA056_Form30_1_Det BL_A056_Form30_1_Det)
		{
			this.BL_A056_Form30_1_Det = BL_A056_Form30_1_Det;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	