using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;
using V4mvc.BusinessLogic;

namespace V4mvc
{
    public partial class ServiceProxyClient : IServiceProxyClient
    {

		#region [ Propiedades ]
		[Dependency]
		public IBLDestinatarios BL_Destinatarios { get; set; }
		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDestinatarios BL_Destinatarios)
		{
			this.BL_Destinatarios = BL_Destinatarios;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<Destinatarios> GetAllDestinatarios(String MODULO)
		{
			try
			{
				return this.BL_Destinatarios.GetAll(MODULO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Destinatarios GetOneDestinatarios(String MODULO)
		{
			try
			{
				if (MODULO == null) { return null; }
				return this.BL_Destinatarios.GetOne(MODULO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveDestinatarios(ref Destinatarios Item)
		{
			try
			{
				return this.BL_Destinatarios.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDestinatarios(ref ObservableCollection<Destinatarios> Items)
		{
			try
			{
				return this.BL_Destinatarios.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
