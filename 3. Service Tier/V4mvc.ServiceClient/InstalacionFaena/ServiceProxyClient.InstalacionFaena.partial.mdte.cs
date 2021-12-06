using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<InstalacionFaena> GetAllInstalacionFaena_Mdte()
        {
            try
            {
                return this.BL_InstalacionFaena.GetAllInstalacionFaena_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
