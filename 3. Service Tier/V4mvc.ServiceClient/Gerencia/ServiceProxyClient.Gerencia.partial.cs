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
        public Gerencia GetOneAutocompleteGerencia(String LIKE_GERENCIA)
        {
            try
            {
                return this.BL_Gerencia.GetOneAutocomplete(LIKE_GERENCIA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        #endregion

    }
}
