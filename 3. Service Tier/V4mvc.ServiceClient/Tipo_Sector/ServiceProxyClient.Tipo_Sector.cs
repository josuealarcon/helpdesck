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
		public IBLTipo_Sector BL_Tipo_Sector { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLTipo_Sector BL_Tipo_Sector)
		{
			this.BL_Tipo_Sector = BL_Tipo_Sector;
		}

		#endregion

		#region [ Consultas ]

		#endregion
		
		#region [ Metodos ]

		#endregion
	}
}
