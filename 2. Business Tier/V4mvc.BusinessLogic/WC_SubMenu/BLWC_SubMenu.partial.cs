using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLWC_SubMenu
    {

        #region [ Consultas ]
        public ObservableCollection<WC_SubMenu> GetAllSubMenuCtta(String TIPOUSUARIO)
        {
            try
            {
                return this.Repository.GetAllSubMenuCtta(TIPOUSUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<WC_SubMenu> GetAllSubMenuMdte(String ADMTIPO, String ADMLUGAR)
        {
            try
            {
                return this.Repository.GetAllSubMenuMdte(ADMTIPO, ADMLUGAR);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
