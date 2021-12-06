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
		public IBLTab_TipoExsico BL_Tab_TipoExsico { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLTab_TipoExsico BL_Tab_TipoExsico)
		{
			this.BL_Tab_TipoExsico = BL_Tab_TipoExsico;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Tab_TipoExsico> GetAllTab_TipoExsico()
		{
			try
			{
				return this.BL_Tab_TipoExsico.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Tab_TipoExsico GetOneTab_TipoExsico(Decimal ID)
		{
			try
			{
				if (ID == null) { return null; }
				return this.BL_Tab_TipoExsico.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean SaveTab_TipoExsico(ref Tab_TipoExsico Item)
		{
			try
			{
				return this.BL_Tab_TipoExsico.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveTab_TipoExsico(ref ObservableCollection<Tab_TipoExsico> Items)
		{
			try
			{
				return this.BL_Tab_TipoExsico.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
