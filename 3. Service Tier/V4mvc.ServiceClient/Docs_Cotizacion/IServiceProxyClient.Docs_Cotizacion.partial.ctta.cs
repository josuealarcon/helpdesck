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
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		ObservableCollection<Docs_Cotizacion> GetAllDocs_CotizacionCtta(ref Docs_Cotizacion model);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
