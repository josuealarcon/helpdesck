using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
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
