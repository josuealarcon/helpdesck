
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAColab_WC_SubMenu
    {
        #region [ Consultas ]
        ObservableCollection<Colab_WC_SubMenu> GetAllColabWCSubMenu_EmpUsuariosCtta(string RUT);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	