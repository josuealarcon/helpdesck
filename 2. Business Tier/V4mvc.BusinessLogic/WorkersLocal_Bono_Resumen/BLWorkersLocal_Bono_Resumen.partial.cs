using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkersLocal_Bono_Resumen
    {

        #region [ Consultas ]

        public ObservableCollection<WorkersLocal_Bono_Resumen> GetWorkersLocal_Bono_ResumenCtta(ref WorkersLocal_Bono_Resumen model)
        {
            try
            {
                return this.Repository.GetWorkersLocal_Bono_ResumenCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
