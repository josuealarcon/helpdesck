using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAAdmin
	{

        #region [ Consultas ]

        Admin ValidarLogin(String ADMRUT, String ADMCLAVE);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
