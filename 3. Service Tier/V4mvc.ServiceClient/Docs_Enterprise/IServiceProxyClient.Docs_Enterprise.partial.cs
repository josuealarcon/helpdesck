using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        ObservableCollection<Docs_Enterprise> GetInformeDocsPendientesEmpresaCtta(ref Docs_Enterprise model);

        #endregion

        #region [ Métodos ]

        #endregion

    }
}