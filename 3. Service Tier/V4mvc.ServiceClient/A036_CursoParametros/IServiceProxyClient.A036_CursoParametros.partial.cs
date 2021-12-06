using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc
{
    public partial interface IServiceProxyClient
    {

        #region [ Consultas ]

        A036_CursoParametros GetA036_CursoParametrosByParametro(int PARAMETRO);

        #endregion

        #region [ Métodos ]

        #endregion

    }
}