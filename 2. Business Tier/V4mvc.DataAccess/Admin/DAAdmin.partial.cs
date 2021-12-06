using System;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAAdmin
    {
        #region [ Consultas ]

        public Admin ValidarLogin(String ADMRUT, String ADMCLAVE)
        {
            try
            {
                Admin item = new Admin();
                Instance.DAAsignarProcedure("V4MVC_ADMIN_VALIDAR_LOGIN");
                Instance.DAAgregarParametro("@ADMRUT", ADMRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ADMCLAVE", ADMCLAVE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
