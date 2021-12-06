
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
		public A400_Auditoria GetOneA400_Auditoria_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST, int IDDOC)
        {
            try
            {
                return this.BL_A400_Auditoria.GetOneA400_Auditoria_ControlLaboralCtta(EMPRESA, PERIODO, DIVISION, OST, IDDOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	