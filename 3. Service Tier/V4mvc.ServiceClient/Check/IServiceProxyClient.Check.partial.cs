using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {
        #region [ Consultas ]
        ObservableCollection<Check> Get_Check_Combo(Check Item);
        #endregion
        #region [ Metodos ]
        #endregion

    }
}