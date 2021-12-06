
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

		public ObservableCollection<LogDocsOST2> GetAllLogDocsOST2_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, int ID_DOC)
        {
            try
            {
                return this.BL_LogDocsOST2.GetAllLogDocsOST2_ContratOSTCtta(NROOST, MADRE, IDEMPRESA, NIVEL, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LogDocsOST2> GetInformeContratosCArranqueHistorialCtta(ref LogDocsOST2 model)
        {
            try
            {
                return this.BL_LogDocsOST2.GetInformeContratosCArranqueHistorialCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	