using System;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLAdmin
    {

        #region [ Consultas ]

        public Admin ValidarLogin(String ADMRUT, String ADMCLAVE)
        {
            try
            {
                return this.Repository.ValidarLogin(ADMRUT, ADMCLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
