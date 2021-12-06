
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_Disputa_CLaboral
    {
        #region [ Consultas ]
        public Docs_Disputa_CLaboral GetOneDocsDisputaCLab_ControlLaboralCtta(int DISPUTA_ID)
        {
            try
            {
                return Repository.GetOneDocsDisputaCLab_ControlLaboralCtta(DISPUTA_ID);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveDocDisputaCLab_ControlLaboralCtta(ref Docs_Disputa_CLaboral instance)
        {
            try
            {
                return Repository.SaveDocDisputaCLab_ControlLaboralCtta(ref instance);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	