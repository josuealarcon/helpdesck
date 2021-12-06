using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAWorkers
    {

        #region [ Consultas ]

        public ObservableCollection<Workers> GetWorkersSearcherMdte(ref Workers model)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SEARCHER_MDTE");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", model.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", model.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", model.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Workers();
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
        public Workers GetFechaHora()
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_GETFEHCAHOY_SELECT");
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
        public ObservableCollection<Workers> GetWorkersMdteSearcherMdte(ref Workers model)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_MDTE_SEARCHER_MDTE");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", model.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", model.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Workers();
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

        public Workers GetOneWorkers_PasesMdte(Docs modelo)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_ONE_PASES_MDTE");
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public Workers GetOneWorkerExtra_PasesMdte(Workers modelo)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_ONE_EXTRAS_PASES_MDTE");
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PASE", modelo.TIPO_PASE, SqlDbType.NVarChar, 12, ParameterDirection.Input);
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

        public Workers GetOneWorkers_CertificacionMdte(Workers modelo)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_ONE_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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


        public Workers GetVerificacionCertificado(string RUT)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_VERIFICACION_CERTIFICADO_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public bool SaveOneWorkers_CertificacionMdte(ref Workers modelo)
        {
            try
            {

                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPSERT_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", modelo.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", modelo.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEXO", modelo.SEXO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

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
    }
}
