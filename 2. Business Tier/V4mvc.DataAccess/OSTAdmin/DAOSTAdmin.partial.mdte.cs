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
	public partial class DAOSTAdmin
	{
        #region [ Consultas ]

        public ObservableCollection<OSTAdmin> GetListOstAdmins_Mdte(string NROOST, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<OSTAdmin> items = new ObservableCollection<OSTAdmin>();
                OSTAdmin item = new OSTAdmin();
                Instance.DAAsignarProcedure("V4MVC_OSTADMIN_SELECT_NROOST_MDTE");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new OSTAdmin();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveOstAdminOST_Mdte(ref OSTAdmin item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_OSTADMIN_INSERT_OST_MDTE");
                            Instance.DAAgregarParametro("@MANDANTE", item.MANDANTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("V4MVC_OSTADMIN_DELETE_OST_MDTE");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_OSTADMIN_UPDATE_OST_MDTE");
                            break;
                    }
                    Instance.DAAgregarParametro("@NROOST", item.NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ADMRUT", item.ADMRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@DIVCOD", item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ADMDELEG", item.ADMDELEG, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                    if (Instance.DAExecuteNonQuery() > 0)
                    { return true; }
                    else
                    { return false; }
                }
                else
                { return true; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
