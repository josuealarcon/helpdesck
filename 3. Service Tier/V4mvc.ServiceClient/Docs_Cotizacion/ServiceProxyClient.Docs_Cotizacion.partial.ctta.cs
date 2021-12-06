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
		public ObservableCollection<Docs_Cotizacion> GetAllDocs_CotizacionCtta(ref Docs_Cotizacion docs_Cotizacion)
		{
			try
			{
				return this.BL_Docs_Cotizacion.GetAllDocs_CotizacionCtta(ref docs_Cotizacion);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
