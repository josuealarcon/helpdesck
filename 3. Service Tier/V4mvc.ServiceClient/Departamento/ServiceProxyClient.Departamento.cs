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
		public IBLDepartamento BL_Departamento { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDepartamento BL_Departamento)
		{
			this.BL_Departamento = BL_Departamento;
		}

		#endregion

		#region [ Consultas ]

		#endregion
		
		#region [ Metodos ]

		#endregion
	}
}
