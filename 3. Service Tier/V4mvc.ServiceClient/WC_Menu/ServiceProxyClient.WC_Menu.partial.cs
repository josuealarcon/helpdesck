using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]

        public ObservableCollection<WC_Menu> GetAllMenuCtta()
        {
            try
            {
                return this.BL_WC_Menu.GetAllMenuCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WC_Menu> GetAllMenuMdte()
        {
            try
            {
                return this.BL_WC_Menu.GetAllMenuMdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
