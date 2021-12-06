using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.DataAccess
{
    public partial interface IDAColab_Usuario
    {

        #region [ Consultas ]

        bool AddColabUsuarioOST_Mdte(string RUT, string IDEMPRESA);

        #endregion

    }
}
