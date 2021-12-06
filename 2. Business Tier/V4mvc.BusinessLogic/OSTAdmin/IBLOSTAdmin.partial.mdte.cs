using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLOSTAdmin
    {
        #region [ Consultas ]

        ObservableCollection<OSTAdmin> GetListOstAdmins_Mdte(string NROOST, string IDEMPRESA);

        #endregion

        #region [ Metodos ]

        bool SaveOstAdminOST_Mdte(ref OSTAdmin Item);
        bool SaveOstAdminOST_Mdte(ObservableCollection<OSTAdmin> Items);

        #endregion

    }
}
