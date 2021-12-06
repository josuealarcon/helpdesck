using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLWorkersLocal_Bono_Resumen
    {

        #region [ Consultas ]

        ObservableCollection<WorkersLocal_Bono_Resumen> GetWorkersLocal_Bono_ResumenCtta(ref WorkersLocal_Bono_Resumen model);
        
        #endregion

        #region [ Métodos ]

        #endregion

    }
}
