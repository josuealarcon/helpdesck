
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLColab_WC_SubMenu
    {
        #region [ Consultas ]

        #endregion
        public ObservableCollection<Colab_WC_SubMenu> GetAllColabWCSubMenu_EmpUsuariosCtta(string RUT)
        {
            try
            {
                return this.Repository.GetAllColabWCSubMenu_EmpUsuariosCtta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #region [ Metodos ]

        #endregion
    }
}
	