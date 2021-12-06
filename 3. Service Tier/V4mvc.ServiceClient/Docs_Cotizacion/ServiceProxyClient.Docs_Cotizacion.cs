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
		public IBLDocs_Cotizacion BL_Docs_Cotizacion { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDocs_Cotizacion BL_Docs_Cotizacion)
		{
			this.BL_Docs_Cotizacion = BL_Docs_Cotizacion;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Docs_Cotizacion> GetAllDocs_Cotizacions()
		{
			try
			{
				return this.BL_Docs_Cotizacion.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Docs_Cotizacion GetOneDocs_Cotizacion(Guid? ID)
		{
			try
			{
				return this.BL_Docs_Cotizacion.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveDocs_Cotizacion(ref Docs_Cotizacion item)
		{
			try
			{
				return this.BL_Docs_Cotizacion.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteDocs_Cotizacion(ref Docs_Cotizacion item)
		{
			try
			{
				return this.BL_Docs_Cotizacion.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveDocs_Cotizacions(ref ObservableCollection<Docs_Cotizacion> items)
		{
			try
			{
				return this.BL_Docs_Cotizacion.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
