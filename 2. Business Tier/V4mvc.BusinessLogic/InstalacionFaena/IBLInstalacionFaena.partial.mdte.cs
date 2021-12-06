using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLInstalacionFaena
    {

        #region [ Consultas ]

        ObservableCollection<InstalacionFaena> GetAllInstalacionFaena_Mdte();

        #endregion

    }
}
