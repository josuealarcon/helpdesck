
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLDocs_Disputa_CLaboral
    {
        #region [ Consultas ]
        Docs_Disputa_CLaboral GetOneDocsDisputaCLab_ControlLaboralCtta(int DISPUTA_ID);
        #endregion

        #region [ Metodos ]
        bool SaveDocDisputaCLab_ControlLaboralCtta(ref Docs_Disputa_CLaboral instance);
        #endregion
    }
}
	