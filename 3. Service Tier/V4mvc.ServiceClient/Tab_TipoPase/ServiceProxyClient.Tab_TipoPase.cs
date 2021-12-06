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
		public IBLTab_TipoPase BL_Tab_TipoPase { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTab_TipoPase BL_Tab_TipoPase)
        {
            this.BL_Tab_TipoPase = BL_Tab_TipoPase;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Tab_TipoPase> GetAllTab_TipoPase()
		{
			try
			{
				return this.BL_Tab_TipoPase.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Tab_TipoPase GetOneTab_TipoPase(Int16 ID_TIPOPASE)
		{
			try
			{
				if (ID_TIPOPASE == null) { return null; }
				return this.BL_Tab_TipoPase.GetOne(ID_TIPOPASE);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTab_TipoPase(ref Tab_TipoPase Item)
		{
			try
			{
				return this.BL_Tab_TipoPase.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTab_TipoPase(ref ObservableCollection<Tab_TipoPase> Items)
		{
			try
			{
				return this.BL_Tab_TipoPase.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
