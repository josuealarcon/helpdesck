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
    public partial class DAOSTDivLocal
    {

        #region [ Consultas ]

        public ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_Mdte(string NROOST, string MANDANTE, string EMPRESA)
        {
            try
            {
                ObservableCollection<OSTDivLocal> items = new ObservableCollection<OSTDivLocal>();
                OSTDivLocal item = new OSTDivLocal();
                Instance.DAAsignarProcedure("V4MVC_OSTDIVLOCAL_SELECT_MDTE");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MANDANTE", MANDANTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new OSTDivLocal();
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

        public bool SaveOstDivLocalOST_Mdte(ref OSTDivLocal item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_OSTDIVLOCAL_INSERT_OST_MDTE");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("V4MVC_OSTDIVLOCAL_DELETE_OST_MDTE");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_OSTDIVLOCAL_UPDATE_OST_MDTE");
                            break;
                    }
                    Instance.DAAgregarParametro("@MANDANTE", item.MANDANTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@DIVISION", item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ADMINOST", item.ADMINOST, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                    Instance.DAAgregarParametro("@ADMINCONTR", item.ADMINCONTR, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
