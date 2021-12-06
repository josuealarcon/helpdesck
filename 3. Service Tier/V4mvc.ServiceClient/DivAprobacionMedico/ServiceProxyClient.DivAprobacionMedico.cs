
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
    public partial class ServiceProxyClient : IServiceProxyClient
    {

		#region [ Propiedades ]
		[Dependency]
		public IBLDivAprobacionMedico BL_DivAprobacionMedico { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLDivAprobacionMedico BL_DivAprobacionMedico)
		{
			this.BL_DivAprobacionMedico = BL_DivAprobacionMedico;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	