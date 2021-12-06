
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLLogDocsOST2
    {

        #region [ Consultas ]

        public ObservableCollection<LogDocsOST2> GetAllLogDocsOST2_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, int ID_DOC)
        {
            try
            {
                return this.Repository.GetAllLogDocsOST2_ContratOSTCtta(NROOST, MADRE, IDEMPRESA, NIVEL, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LogDocsOST2> GetInformeContratosCArranqueHistorialCtta(ref LogDocsOST2 model)
        {
            try
            {
                return this.Repository.GetInformeContratosCArranqueHistorialCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	