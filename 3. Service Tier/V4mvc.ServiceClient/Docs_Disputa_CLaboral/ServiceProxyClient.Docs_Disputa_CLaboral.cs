
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
		public IBLDocs_Disputa_CLaboral BL_Docs_Disputa_CLaboral { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLDocs_Disputa_CLaboral BL_Docs_Disputa_CLaboral)
		{
			this.BL_Docs_Disputa_CLaboral = BL_Docs_Disputa_CLaboral;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	