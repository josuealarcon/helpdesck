using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DACcostos
    {

        #region [ Consultas ]

        public ObservableCollection<Ccostos> GetAllCcostosEnterpriseCtta(string EMPRESA)
        {
            try
            {
                ObservableCollection<Ccostos> items = new ObservableCollection<Ccostos>();
                Ccostos item = new Ccostos();
                Instance.DAAsignarProcedure("V4MVC_CCOSTOS_SELECT_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Ccostos();
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

        public Ccostos GetOneCcostoEnterpriseCtta(string EMPRESA, string CCOSTO)
        {
            try
            {
                Ccostos item = new Ccostos();
                Instance.DAAsignarProcedure("V4MVC_CCOSTOS_SELECT_CCOSTO_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CCOSTO", CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
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
        public ObservableCollection<Ccostos> GetCCostosSearcherCtta(ref Ccostos model)
        {
            try
            {
                ObservableCollection<Ccostos> items = new ObservableCollection<Ccostos>();
                Ccostos item = new Ccostos();

                Instance.DAAsignarProcedure("V4MVC_CCOSTOS_SELECT_SEARCHER_CTTA");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CCOSTO", model.COL0, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIPCION", model.COL1, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Ccostos();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                model.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        public bool ValidateCcosto_Ctta(string IDEMPRESA, string CCOSTO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_CCOSTOS_VALIDATE_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CCOSTO", CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() > 0 ? false : true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveCcostoEntepriseCtta(ref Ccostos item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_CCOSTOS_ENTERPRISE_SAVE_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CCOSTO", item.CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);

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
