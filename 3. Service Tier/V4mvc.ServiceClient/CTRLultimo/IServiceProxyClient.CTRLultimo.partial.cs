using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]
        #endregion
        #region [ Informes ]
        ObservableCollection<CTRLultimo> GetWorkers_GridMovimientos_FichaRut_InformeConsultaRapidaCtta(CTRLultimo Item);
        #endregion
        #region [ Metodos ]
        #endregion

    }
}