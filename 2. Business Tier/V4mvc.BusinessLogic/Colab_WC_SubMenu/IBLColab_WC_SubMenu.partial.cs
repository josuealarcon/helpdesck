
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLColab_WC_SubMenu
    {
        #region [ Consultas ]
        ObservableCollection<Colab_WC_SubMenu> GetAllColabWCSubMenu_EmpUsuariosCtta(string RUT);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	