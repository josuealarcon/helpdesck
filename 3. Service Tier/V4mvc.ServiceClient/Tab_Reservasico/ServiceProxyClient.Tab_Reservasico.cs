using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
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
		public IBLTab_Reservasico BL_Tab_Reservasico { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLTab_Reservasico BL_Tab_Reservasico)
		{
			this.BL_Tab_Reservasico = BL_Tab_Reservasico;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<Tab_Reservasico> GetAllTab_Reservasico()
		{
			try
			{
				return this.BL_Tab_Reservasico.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Tab_Reservasico GetOneTab_Reservasico(Decimal ID)
		{
			try
			{
				return this.BL_Tab_Reservasico.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveTab_Reservasico(ref Tab_Reservasico Item)
		{
			try
			{
				return this.BL_Tab_Reservasico.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTab_Reservasico(ref ObservableCollection<Tab_Reservasico> Items)
		{
			try
			{
				return this.BL_Tab_Reservasico.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
