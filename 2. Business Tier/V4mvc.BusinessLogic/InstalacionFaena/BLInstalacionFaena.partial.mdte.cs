using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLInstalacionFaena
    {

        #region [ Consultas ]

        public ObservableCollection<InstalacionFaena> GetAllInstalacionFaena_Mdte()
        {
            try
            {
                return this.Repository.GetAllInstalacionFaena_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
