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
		public IBLOSTArbol BL_OSTArbol { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLOSTArbol BL_OSTArbol)
        {
            this.BL_OSTArbol = BL_OSTArbol;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<OSTArbol> GetAllOSTArbol( OSTArbol oSTArbol)
		{
			try
			{
				return this.BL_OSTArbol.GetAll(oSTArbol);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public OSTArbol GetOneOSTArbol(String OST, String MADRE, String EMPRESA)
		{
			try
			{
				if (OST == null || MADRE == null || EMPRESA == null) { return null; }
				return this.BL_OSTArbol.GetOne(OST, MADRE, EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveOSTArbol(ref OSTArbol Item)
		{
			try
			{
				return this.BL_OSTArbol.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveOSTArbol(ref ObservableCollection<OSTArbol> Items)
		{
			try
			{
				return this.BL_OSTArbol.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
