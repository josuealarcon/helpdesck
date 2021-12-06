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

        public Admin ValidarLoginAdmin(String ADMRUT, String ADMCLAVE)
        {
            try
            {
                return this.BL_Admin.ValidarLogin(ADMRUT, ADMCLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
