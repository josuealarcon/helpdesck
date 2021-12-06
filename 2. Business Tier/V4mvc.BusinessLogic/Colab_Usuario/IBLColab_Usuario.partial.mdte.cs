using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLColab_Usuario
    {

        #region [ Consultas ]

        bool AddColabUsuarioOST_Mdte(string RUT, string IDEMPRESA);

        #endregion

    }
}
