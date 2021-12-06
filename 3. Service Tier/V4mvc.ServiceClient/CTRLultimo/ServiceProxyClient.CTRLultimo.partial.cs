using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
        #endregion
        #region [ Informes ]
        public ObservableCollection<CTRLultimo> GetWorkers_GridMovimientos_FichaRut_InformeConsultaRapidaCtta(CTRLultimo Item)
        {
            try
            {
                return this.BL_CTRLultimo.GetWorkers_GridMovimientos_FichaRut_InformeConsultaRapidaCtta(Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region [ Metodos ]
        #endregion

    }
}
