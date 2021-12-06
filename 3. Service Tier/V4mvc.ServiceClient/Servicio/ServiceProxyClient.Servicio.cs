using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLServicio BL_Servicio { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLServicio BL_Servicio)
		{
			this.BL_Servicio = BL_Servicio;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Servicio> GetAllServicio()
		{
			try
			{
				return this.BL_Servicio.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Servicio GetOneServicio(string SERVICIO)
		{
			try
			{
				if (SERVICIO == null) { return null; }
				return this.BL_Servicio.GetOne(SERVICIO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean SaveServicio(ref Servicio Item)
		{
			try
			{
				return this.BL_Servicio.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveServicio(ref ObservableCollection<Servicio> Items)
		{
			try
			{
				return this.BL_Servicio.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
