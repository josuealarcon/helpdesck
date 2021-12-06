
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
        public Docs_Disputa_CLaboral GetOneDocsDisputaCLab_ControlLaboralCtta(int DISPUTA_ID)
        {
            try
            {
                return this.BL_Docs_Disputa_CLaboral.GetOneDocsDisputaCLab_ControlLaboralCtta(DISPUTA_ID);
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
                return this.BL_Docs_Disputa_CLaboral.SaveDocDisputaCLab_ControlLaboralCtta(ref instance);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	