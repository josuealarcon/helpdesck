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
    public partial class DACharlas_Division
    {
        #region [ Consultas ]
        public ObservableCollection<Charlas_Division> GetListDivisionesCharlas_Mdte(int IDCHARLA)
        {
            try
            {
                var items = new ObservableCollection<Charlas_Division>();
                Instance.DAAsignarProcedure("V4MVC_CHARLAS_DIVISION_SELECT_EVALUACIONES_MDTE");
                Instance.DAAgregarParametro("@IDCHARLA", IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Charlas_Division();
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

        public bool DeleteAll(int IDCHARLA)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_CHARLAS_DIVISION_DELETE_ALL_MDTE");
                Instance.DAAgregarParametro("@IDCHARLA", IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
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
