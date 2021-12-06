using System;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCTRLultimo
    {

        #region [ Consultas ]
        #endregion
        #region [ Informes ]
        public ObservableCollection<CTRLultimo> GetWorkers_GridMovimientos_FichaRut_InformeConsultaRapidaCtta(CTRLultimo Item)
        {
            try
            {
                return this.Repository.GetWorkers_GridMovimientos_FichaRut_InformeConsultaRapidaCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
