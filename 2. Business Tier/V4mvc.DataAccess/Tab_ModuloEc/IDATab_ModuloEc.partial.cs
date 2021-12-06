
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDATab_ModuloEc
    {
        #region [ Consultas ]
        ObservableCollection<Tab_ModuloEc> GetAllTabModuloEc_EmpUsuariosCtta();
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	