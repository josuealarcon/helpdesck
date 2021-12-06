
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLTab_ModuloEc
    {
        #region [ Consultas ]
        public ObservableCollection<Tab_ModuloEc> GetAllTabModuloEc_EmpUsuariosCtta()
        {
            try
            {
                return this.Repository.GetAllTabModuloEc_EmpUsuariosCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	