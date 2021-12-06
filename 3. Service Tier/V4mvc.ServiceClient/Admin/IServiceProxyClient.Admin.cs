using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {
        #region [ Consultas ]
        ObservableCollection<Admin> GetAllAdmin();
        Admin GetOneAdmin(String ADMRUT);
        #endregion

        #region [ Metodos ]
        Boolean SaveAdmin(ref Admin Item);
        Boolean SaveAdmin(ref ObservableCollection<Admin> Items);
        #endregion
    }
}
