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
		public IBLTab_Tipocotizacion BL_Tab_Tipocotizacion { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLTab_Tipocotizacion BL_Tab_Tipocotizacion)
		{
			this.BL_Tab_Tipocotizacion = BL_Tab_Tipocotizacion;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Tab_Tipocotizacion> GetAllTab_Tipocotizaciones()
		{
			try
			{
				return this.BL_Tab_Tipocotizacion.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Tab_Tipocotizacion GetOneTab_Tipocotizacion(Int16 ID)
		{
			try
			{
				return this.BL_Tab_Tipocotizacion.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveTab_Tipocotizacion(ref Tab_Tipocotizacion item)
		{
			try
			{
				return this.BL_Tab_Tipocotizacion.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteTab_Tipocotizacion(ref Tab_Tipocotizacion item)
		{
			try
			{
				return this.BL_Tab_Tipocotizacion.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveTab_Tipocotizaciones(ref ObservableCollection<Tab_Tipocotizacion> items)
		{
			try
			{
				return this.BL_Tab_Tipocotizacion.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
