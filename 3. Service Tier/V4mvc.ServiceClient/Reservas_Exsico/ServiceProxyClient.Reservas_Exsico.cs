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
		public IBLReservas_Exsico BL_Reservas_Exsico { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLReservas_Exsico BL_Reservas_Exsico)
		{
			this.BL_Reservas_Exsico = BL_Reservas_Exsico;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Reservas_Exsico> GetAllReservas_Exsico()
		{
			try
			{
				return this.BL_Reservas_Exsico.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Reservas_Exsico GetOneReservas_Exsico(Decimal ID)
		{
			try
			{
				return this.BL_Reservas_Exsico.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean SaveReservas_Exsico(ref Reservas_Exsico Item)
		{
			try
			{
				return this.BL_Reservas_Exsico.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveReservas_Exsico(ref ObservableCollection<Reservas_Exsico> Items)
		{
			try
			{
				return this.BL_Reservas_Exsico.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
