using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLWC_Menu
	{

        #region [ Consultas ]

        public ObservableCollection<WC_Menu> GetAllMenuCtta()
        {
            try
            {
                return this.Repository.GetAllMenuCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WC_Menu> GetAllMenuMdte()
        {
            try
            {
                return this.Repository.GetAllMenuMdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
