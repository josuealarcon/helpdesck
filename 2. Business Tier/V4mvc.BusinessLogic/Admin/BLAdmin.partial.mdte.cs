using System;

namespace V4mvc.BusinessLogic
{
    public partial class BLAdmin
    {

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]

        public bool UpdateClaveAdmin(string RUT, string NEWPASSWORD)
        {
            try
            {
                return this.Repository.UpdateClaveAdmin(RUT, NEWPASSWORD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveMdte(string RUT, string CLAVE)
        {
            try
            {
                return this.Repository.ValidarClaveMdte(RUT, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveHistoricoMdte(string RUT, string CLAVE)
        {
            try
            {
                return this.Repository.ValidarClaveHistoricoMdte(RUT, CLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveMdte(string RUT, string NUEVACLAVE)
        {
            try
            {
                return this.Repository.CambioClaveMdte(RUT, NUEVACLAVE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveHistoricoMdte(string RUT, string NUEVACLAVE, string IP)
        {
            try
            {
                return this.Repository.CambioClaveHistoricoMdte(RUT, NUEVACLAVE, IP);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
