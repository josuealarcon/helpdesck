using System;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLGerencia
    {

        #region [ Consultas ]
        public Gerencia GetOneAutocomplete(String LIKE_GERENCIA)
        {
            try
            {
                return this.Repository.GetOneAutocomplete(LIKE_GERENCIA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}