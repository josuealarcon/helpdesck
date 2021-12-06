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

        public A036_CursoProg_Docs GetA036CursoProgDocsCodigoCtta(int CODIGO)
        {
            try
            {
                return this.BL_A036_CursoProg_Docs.GetA036CursoProgDocsCodigoCtta(CODIGO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
