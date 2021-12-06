
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
		public IBLColab_WC_SubMenu BL_Colab_WC_SubMenu { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLColab_WC_SubMenu BL_Colab_WC_SubMenu)
		{
			this.BL_Colab_WC_SubMenu = BL_Colab_WC_SubMenu;
		}

		#endregion

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		#endregion
	}
}
	