
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
		public IBLDocs_OST2 BL_Docs_OST2 { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLDocs_OST2 BL_Docs_OST2)
		{
			this.BL_Docs_OST2 = BL_Docs_OST2;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	