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

        public ObservableCollection<WC_SubMenu> GetAllSubMenuCtta(String TIPOUSUARIO)
        {
            try
            {
                return this.BL_WC_SubMenu.GetAllSubMenuCtta(TIPOUSUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WC_SubMenu> GetAllSubMenuMdte(String ADMTIPO, String ADMLUGAR)
        {
            try
            {
                return this.BL_WC_SubMenu.GetAllSubMenuMdte(ADMTIPO, ADMLUGAR);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
