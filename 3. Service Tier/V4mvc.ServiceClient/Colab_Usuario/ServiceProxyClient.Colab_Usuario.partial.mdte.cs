using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public bool AddColabUsuarioOST_Mdte(string RUT, string IDEMPRESA)
        {
            try
            {
                return this.BL_Colab_Usuario.AddColabUsuarioOST_Mdte(RUT, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
