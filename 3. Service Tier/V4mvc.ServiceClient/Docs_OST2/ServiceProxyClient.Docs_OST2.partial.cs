
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

		#region [ Consultas ]

		public ObservableCollection<Docs_OST2> GetInformeContratosCArranqueDocsOst2Ctta(ref Docs_OST2 model)
		{
			try
			{
				return this.BL_Docs_OST2.GetInformeContratosCArranqueDocsOst2Ctta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
	