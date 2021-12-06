using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Microsoft.Practices.EnterpriseLibrary.Data;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DALicencias
    {
        #region [ Consultas ]

        public ObservableCollection<Licencias> GetLicenciasConductores(string RUT)
        {
            try
            {
                ObservableCollection<Licencias> items = new ObservableCollection<Licencias>();
                Licencias item = new Licencias();
                Instance.DAAsignarProcedure("V4MVC_LICENCIAS_SELECT_CONDUCTORES_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Licencias();
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
        public bool SaveWorkersLicenciasConductoresCtta(string RUT, string licencias)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_LICENCIAS_UPDATE_CONDUCTORES_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LICENCIAS", licencias, SqlDbType.NVarChar, 200, ParameterDirection.Input);

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
