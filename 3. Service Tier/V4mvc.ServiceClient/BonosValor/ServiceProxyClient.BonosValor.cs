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
		public IBLBonosValor BL_BonosValor { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLBonosValor BL_BonosValor)
		{
			this.BL_BonosValor = BL_BonosValor;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<BonosValor> GetAllBonosValor()
		{
			try
			{
				return this.BL_BonosValor.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public BonosValor GetOneBonosValor()
		{
			try
			{
				return null;//this.BL_BonosValor.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveBonosValor(ref BonosValor Item)
		{
			try
			{
				return this.BL_BonosValor.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveBonosValor(ref ObservableCollection<BonosValor> Items)
		{
			try
			{
				return this.BL_BonosValor.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
