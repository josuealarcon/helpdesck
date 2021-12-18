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
		public IBLSolicitud BL_Solicitud { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLSolicitud BL_Solicitud)
		{
			this.BL_Solicitud = BL_Solicitud;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Solicitud> GetAllSolicituds()
		{
			try
			{
				return this.BL_Solicitud.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Solicitud GetOneSolicitud(Int32 ID_SOLICITUD)
		{
			try
			{
				return this.BL_Solicitud.GetOne(ID_SOLICITUD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveSolicitud(ref Solicitud item)
		{
			try
			{
				return this.BL_Solicitud.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteSolicitud(ref Solicitud item)
		{
			try
			{
				return this.BL_Solicitud.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveSolicituds(ref ObservableCollection<Solicitud> items)
		{
			try
			{
				return this.BL_Solicitud.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
