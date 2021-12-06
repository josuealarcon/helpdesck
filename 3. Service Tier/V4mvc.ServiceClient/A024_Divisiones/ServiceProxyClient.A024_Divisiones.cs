
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
		public IBLA024_Divisiones BL_A024_Divisiones { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLA024_Divisiones BL_A024_Divisiones)
		{
			this.BL_A024_Divisiones = BL_A024_Divisiones;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	