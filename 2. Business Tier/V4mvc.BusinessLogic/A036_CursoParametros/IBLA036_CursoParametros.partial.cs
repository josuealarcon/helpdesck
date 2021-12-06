using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLA036_CursoParametros
    {

        #region [ Consultas ]

        A036_CursoParametros GetA036_CursoParametrosByParametro(int PARAMETRO);

        #endregion

        #region [ Métodos ]

        #endregion

    }
}