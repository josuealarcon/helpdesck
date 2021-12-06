using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial class BLA036_CursoParametros
    {

        #region [ Consultas ]

        public A036_CursoParametros GetA036_CursoParametrosByParametro(int PARAMETRO)
        {
            try
            {
                return this.Repository.GetA036_CursoParametrosByParametro(PARAMETRO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
