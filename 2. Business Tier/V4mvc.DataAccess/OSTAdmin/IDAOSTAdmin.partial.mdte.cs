using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAOSTAdmin
    {
        #region [ Consultas ]

        ObservableCollection<OSTAdmin> GetListOstAdmins_Mdte(string NROOST, string IDEMPRESA);

        #endregion

        #region [ Metodos ]

        bool SaveOstAdminOST_Mdte(ref OSTAdmin Item);

        #endregion
    }
}
