
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLA400_Auditoria
    {
        #region [ Consultas ]
        A400_Auditoria GetOneA400_Auditoria_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST, int IDDOC);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	