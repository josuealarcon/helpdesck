using System;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAColab_Usuario
    {

        #region [ Consultas ]

        public bool AddColabUsuarioOST_Mdte(string RUT, string IDEMPRESA)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_AGREGARUSUARIO_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
