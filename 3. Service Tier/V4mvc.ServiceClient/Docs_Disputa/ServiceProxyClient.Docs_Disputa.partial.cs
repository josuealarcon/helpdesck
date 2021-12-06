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

        public ObservableCollection<Docs_Disputa> GetInformeDocsPendientesDisputaCtta(ref Docs_Disputa model)
        {
            try
            {
                return this.BL_Docs_Disputa.GetInformeDocsPendientesDisputaCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveDisputa(ref Docs_Disputa Item)
        {
            try
            {
                return this.BL_Docs_Disputa.SaveDisputa(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
