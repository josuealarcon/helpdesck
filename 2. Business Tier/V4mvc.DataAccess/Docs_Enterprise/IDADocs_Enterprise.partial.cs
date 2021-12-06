using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs_Enterprise
    {

        #region [ Consultas ]

        ObservableCollection<Docs_Enterprise> GetInformeDocsPendientesEmpresaCtta(ref Docs_Enterprise model);

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
