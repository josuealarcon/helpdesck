using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;


namespace V4mvc.DataAccess
{
    public partial class DAEnterprise
    {

        #region [ Consultas ]

        public ObservableCollection<Enterprise> GetEnterprisesMdteSearcherMdte(ref Enterprise model)
        {
            try
            {
                ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
                Enterprise item = new Enterprise();
                Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_MDTE_SEARCHER_MDTE");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", model.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", model.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Enterprise();
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

        public ObservableCollection<Enterprise> GetEnterprisesCttaSearcherMdte(ref Enterprise model)
        {
            try
            {
                ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
                Enterprise item = new Enterprise();
                Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_CTTA_SEARCHER_MDTE");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", model.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", model.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Enterprise();
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

        public ObservableCollection<Enterprise> GetAllEnterpriseCamo_Mdte(string MADRE, string EMPRESA, string NROOST)
        {
            try
            {
                ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
                Enterprise item = new Enterprise();
                Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT_CAMO_MDTE");
                Instance.DAAgregarParametro("@MANDANTE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Enterprise();
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
        public ObservableCollection<Enterprise> GetAllEnterprise_Mdte(string RUT, string DIVCOD)
        {
            try
            {
                ObservableCollection<Enterprise> items = new ObservableCollection<Enterprise>();
                Enterprise item = new Enterprise();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_EMPRESAS_FUNCIONARIOS_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);              
              
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Enterprise();
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
     
        public Enterprise GetOneEnterprise_CertificacionMdte(string IDEMPRESA)
        {
            try
            {
                var item = new Enterprise();
                Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT_ONE_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        public Enterprise GetOneEnterprise_CertificacionMdte(Enterprise modelo)
        {
            try
            {
                var item = new Enterprise();
                Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_SELECT_ONE_V2_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        #region [ Métodos ]

        public bool SaveOneEnterprise_CertificacionMdte(ref Enterprise modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_ENTERPRISE_UPSERT_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", modelo.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", modelo.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
