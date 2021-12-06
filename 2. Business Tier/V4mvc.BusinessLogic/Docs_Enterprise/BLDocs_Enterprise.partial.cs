using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_Enterprise
    {

        #region [ Consultas ]

        public ObservableCollection<Docs_Enterprise> GetInformeDocsPendientesEmpresaCtta(ref Docs_Enterprise model)
        {
            try
            {
                return Repository.GetInformeDocsPendientesEmpresaCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
