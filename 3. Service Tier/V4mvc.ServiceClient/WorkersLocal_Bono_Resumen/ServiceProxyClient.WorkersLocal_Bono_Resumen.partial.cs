using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<WorkersLocal_Bono_Resumen> GetWorkersLocal_Bono_ResumenCtta(ref WorkersLocal_Bono_Resumen model)
        {
            try
            {
                return this.BL_WorkersLocal_Bono_Resumen.GetWorkersLocal_Bono_ResumenCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
