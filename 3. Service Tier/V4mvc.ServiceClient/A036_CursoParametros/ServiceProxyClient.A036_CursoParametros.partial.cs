using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using System.Data;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public A036_CursoParametros GetA036_CursoParametrosByParametro(int PARAMETRO)
        {
            try
            {
                return this.BL_A036_CursoParametros.GetA036_CursoParametrosByParametro(PARAMETRO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
