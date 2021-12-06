using System;
using System.Data;

namespace V4mvc.DataAccess
{
    public partial class DAAdmin
    {

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]

        public bool UpdateClaveAdmin(string RUT, string NEWPASSWORD)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_UPDATE_ADMIN_CAMBIOCLAVE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NEWPASSWORD", NEWPASSWORD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveMdte(string RUT, string CLAVE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_ADMIN_VALIDARCLAVE_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", CLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() > 0 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveHistoricoMdte(string RUT, string CLAVE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_ADMIN_VALIDARCLAVEHISTORICO_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", CLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() > 0 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveMdte(string RUT, string NUEVACLAVE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_ADMIN_CAMBIOCLAVE_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NUEVACLAVE", NUEVACLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveHistoricoMdte(string RUT, string NUEVACLAVE, string IP)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_ADMIN_CAMBIOCLAVE_HISTORICO_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NUEVACLAVE", NUEVACLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IP", IP, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
