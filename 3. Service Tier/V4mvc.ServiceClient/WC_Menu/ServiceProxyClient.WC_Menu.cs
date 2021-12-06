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
		public IBLWC_Menu BL_WC_Menu { get; set; }
        #endregion


        #region [ Constructor]
        public ServiceProxyClient(IBLWC_Menu BL_WC_Menu)
        {
            this.BL_WC_Menu = BL_WC_Menu;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<WC_Menu> GetAllWC_Menu()
		{
			try
			{
				return this.BL_WC_Menu.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public WC_Menu GetOneWC_Menu(Decimal CODMENU)
		{
			try
			{
				return this.BL_WC_Menu.GetOne(CODMENU);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveWC_Menu(ref WC_Menu Item)
		{
			try
			{
				return this.BL_WC_Menu.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveWC_Menu(ref ObservableCollection<WC_Menu> Items)
		{
			try
			{
				return this.BL_WC_Menu.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
