using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAWC_Menu
    {

        #region [ Consultas ]

        ObservableCollection<WC_Menu> GetAllMenuCtta();
        ObservableCollection<WC_Menu> GetAllMenuMdte();

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
