using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.BusinessLogic
{
    public partial class BLColab_Usuario
    {

        #region [ Consultas ]

        public bool AddColabUsuarioOST_Mdte(string RUT, string IDEMPRESA)
        {
            try
            {
                return this.Repository.AddColabUsuarioOST_Mdte(RUT, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
