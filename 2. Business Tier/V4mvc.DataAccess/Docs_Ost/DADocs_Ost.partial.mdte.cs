using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DADocs_Ost
    {
        #region [ Consultas ]

        public Docs_Ost GetOneDocs_Ost_Mdte(string OST, string MADRE, string EMPRESA, Int16 NIVEL)
        {
            try
            {
                var item = new Docs_Ost();
                Instance.DAAsignarProcedure("V4MVC_DOCS_OST_SELECT_MDTE");
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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

        public bool DeleteDocs_Ost(ref Docs_Ost item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_OST_DELETE_MDTE");
                Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", item.NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
