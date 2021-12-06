using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAWorkersLocal
    {
        #region [ Consultas ]
        public ObservableCollection<WorkersLocal> GetWorkersLocal_PasesFuncionarios(String RUT, String DIVCOD)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_PASES_FUNCIONARIOS_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WorkersLocal();
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

        public ObservableCollection<WorkersLocal> GetWorkersLocal_Archivos(String RUT, int ID_DOC)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WorkersLocal();
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

        #region [ Informes ]


        #endregion

        #region [ Metodos ]
        public bool SaveOneWorkersLocal_CertificacionMdte(Workers modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_INSERT_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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

        public bool SaveCertificadoFuncionario(ref WorkersLocal modelo)
        {
            try
            {
                if (modelo.Instance != InstanceEntity.Unchanged)
                {
                    switch (modelo.Instance)
                    {                      
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_INSERT_PASES_FUNCIONARIOS_MDTE");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_DELETE_PASES_FUNCIONARIOS_MDTE");
                            break;
                    }
                    if ( modelo.Instance == InstanceEntity.Delete)
                    {
                        Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);                       
                        Instance.DAAgregarParametro("@EMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                        if (Instance.DAExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        { return false; }
                    }
                    if (modelo.Instance == InstanceEntity.New)
                    {
                        Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                        modelo.VALOR = Convert.ToInt32(Instance.DAExecuteScalar());
                        return true;
                    }
                    else { return false; }

                }
                else
                { return true; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ func_getdatos V3 ]

        #endregion
    }
}
