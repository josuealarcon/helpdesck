using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAInstalacionFaena
    {

        #region [ Consultas ]

        ObservableCollection<InstalacionFaena> GetAllInstalacionFaena_Mdte();

        #endregion

    }
}
