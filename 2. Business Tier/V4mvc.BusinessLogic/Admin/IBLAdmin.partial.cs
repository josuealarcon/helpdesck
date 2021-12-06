using System;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLAdmin
	{

        #region [ Consultas ]

        Admin ValidarLogin(String ADMRUT, String ADMCLAVE);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
