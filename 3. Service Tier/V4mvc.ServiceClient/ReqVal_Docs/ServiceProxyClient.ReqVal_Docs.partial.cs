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

        public ObservableCollection<ReqVal_Docs> GetDocumentoRequisitos(int ID_DOC)
        {
            try
            {
                return this.BL_ReqVal_Docs.GetDocumentoRequisitos(ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
