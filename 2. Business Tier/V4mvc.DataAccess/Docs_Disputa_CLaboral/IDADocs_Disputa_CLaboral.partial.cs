
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs_Disputa_CLaboral
    {
        #region [ Consultas ]
        Docs_Disputa_CLaboral GetOneDocsDisputaCLab_ControlLaboralCtta(int DISPUTA_ID);
        #endregion

        #region [ Metodos ]
        bool SaveDocDisputaCLab_ControlLaboralCtta(ref Docs_Disputa_CLaboral instance);
        #endregion
    }
}
	