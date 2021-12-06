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

        #endregion

        #region [ Metodos ]

        public bool UpdateClaveAdmin(string RUT, string NEWPASSWORD)
        {
            try
            {
                return this.BL_Admin.UpdateClaveAdmin(RUT, NEWPASSWORD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveMdte(string RUT, string CLAVE)
        {
            try
            {
                return this.BL_Admin.ValidarClaveMdte(RUT, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveHistoricoMdte(string RUT, string CLAVE)
        {
            try
            {
                return this.BL_Admin.ValidarClaveHistoricoMdte(RUT, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveMdte(string RUT, string NUEVACLAVE)
        {
            try
            {
                return this.BL_Admin.CambioClaveMdte(RUT, NUEVACLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveHistoricoMdte(string RUT, string NUEVACLAVE, string IP)
        {
            try
            {
                return this.BL_Admin.CambioClaveHistoricoMdte(RUT, NUEVACLAVE, IP);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
