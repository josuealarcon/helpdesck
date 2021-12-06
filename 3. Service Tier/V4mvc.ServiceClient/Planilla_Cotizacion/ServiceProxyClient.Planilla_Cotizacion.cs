
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
		public IBLPlanilla_Cotizacion BL_Planilla_Cotizacion { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLPlanilla_Cotizacion BL_Planilla_Cotizacion)
		{
			this.BL_Planilla_Cotizacion = BL_Planilla_Cotizacion;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	