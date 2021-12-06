
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
		public IBLA400_Auditoria BL_A400_Auditoria { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLA400_Auditoria BL_A400_Auditoria)
		{
			this.BL_A400_Auditoria = BL_A400_Auditoria;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	