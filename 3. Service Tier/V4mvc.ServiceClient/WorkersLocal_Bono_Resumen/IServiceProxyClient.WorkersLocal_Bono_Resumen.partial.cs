using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        ObservableCollection<WorkersLocal_Bono_Resumen> GetWorkersLocal_Bono_ResumenCtta(ref WorkersLocal_Bono_Resumen model);

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
