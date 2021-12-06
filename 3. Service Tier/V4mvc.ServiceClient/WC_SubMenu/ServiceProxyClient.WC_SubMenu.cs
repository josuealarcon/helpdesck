using System;
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
		public IBLWC_SubMenu BL_WC_SubMenu { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLWC_SubMenu BL_WC_SubMenu)
        {
            this.BL_WC_SubMenu = BL_WC_SubMenu;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<WC_SubMenu> GetAllWC_SubMenu()
		{
			try
			{
				return this.BL_WC_SubMenu.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public WC_SubMenu GetOneWC_SubMenu(Decimal CODSUBMENU)
		{
			try
			{
				return this.BL_WC_SubMenu.GetOne(CODSUBMENU);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveWC_SubMenu(ref WC_SubMenu Item)
		{
			try
			{
				return this.BL_WC_SubMenu.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveWC_SubMenu(ref ObservableCollection<WC_SubMenu> Items)
		{
			try
			{
				return this.BL_WC_SubMenu.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
