using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLGerencia
    {

        #region [ Consultas ]
        Gerencia GetOneAutocomplete(String LIKE_GERENCIA);
        #endregion

        #region [ Metodos ]
        #endregion

    }
}

