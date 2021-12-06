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

        public ObservableCollection<WorkersLocal> GetWorkersLocalLaborales(String RUT, String EMPRESA)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_LABORALES_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
    
        public WorkersLocal GetOneWorkersLocalPaseFuncionario_Ctta(string RUT, string DIVISION, string EMPRESA)
        {
            try
            {
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_PASEFUNCIONARIO_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        public ObservableCollection<WorkersLocal> GetWorkersLocalEnterprise(String EMPRESA)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_ENTERPRISE");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<WorkersLocal> GetWorkersLocalDocPendientesSelect(String EMPRESA)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_DOC_PENDIENTES_SELECT");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<WorkersLocal> GetWorkersLocalSelectB(String EMPRESA, String DIVCOD)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_B");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public WorkersLocal GetWorkersLocalSelectC(String EMPRESA, String DIVCOD, String RUT)
        {
            try
            {
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_C");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumen_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_ICERTRESUMEN_INFORMES_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                Instance.DAAgregarParametro("@SUMA_FUNCIONARIOS_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_CERTIFICADOS_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_NOCERTIFICADOS_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_SI_AUTOR_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);

                Instance.DAAgregarParametro("@SUMA_FUNCIONARIOS_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_CERTIFICADOS_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_NOCERTIFICADOS_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_SI_AUTOR_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);

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

                if (Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_CTTA"].Value != null)
                    resumen.SUMA_FUNCIONARIOS_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_CTTA"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_CTTA"].Value != null)
                    resumen.SUMA_CERTIFICADOS_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_CTTA"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_CTTA"].Value != null)
                    resumen.SUMA_NOCERTIFICADOS_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_CTTA"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_SI_AUTOR_CTTA"].Value != null)
                    resumen.SUMA_SI_AUTOR_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_SI_AUTOR_CTTA"].Value.ToString());

                if (Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_MDTE"].Value != null)
                    resumen.SUMA_FUNCIONARIOS_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_MDTE"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_MDTE"].Value != null)
                    resumen.SUMA_CERTIFICADOS_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_MDTE"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_MDTE"].Value != null)
                    resumen.SUMA_NOCERTIFICADOS_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_MDTE"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_SI_AUTOR_MDTE"].Value != null)
                    resumen.SUMA_SI_AUTOR_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_SI_AUTOR_MDTE"].Value.ToString());

                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_ICertResumenOST_Informes(string EMPRESA, string DIVISION, ref WorkersLocal resumen)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_ICERTRESUMENOST_INFORMES_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                Instance.DAAgregarParametro("@SUMA_FUNCIONARIOS_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_CERTIFICADOS_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_NOCERTIFICADOS_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_HISTORICO_CTTA", 0, SqlDbType.Int, 8, ParameterDirection.Output);

                Instance.DAAgregarParametro("@SUMA_FUNCIONARIOS_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_CERTIFICADOS_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_NOCERTIFICADOS_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@SUMA_HISTORICO_MDTE", 0, SqlDbType.Int, 8, ParameterDirection.Output);

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

                if (Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_CTTA"].Value != null)
                    resumen.SUMA_FUNCIONARIOS_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_CTTA"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_CTTA"].Value != null)
                    resumen.SUMA_CERTIFICADOS_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_CTTA"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_CTTA"].Value != null)
                    resumen.SUMA_NOCERTIFICADOS_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_CTTA"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_HISTORICO_CTTA"].Value != null)
                    resumen.SUMA_HISTORICO_CTTA = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_HISTORICO_CTTA"].Value.ToString());

                if (Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_MDTE"].Value != null)
                    resumen.SUMA_FUNCIONARIOS_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_FUNCIONARIOS_MDTE"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_MDTE"].Value != null)
                    resumen.SUMA_CERTIFICADOS_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_CERTIFICADOS_MDTE"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_MDTE"].Value != null)
                    resumen.SUMA_NOCERTIFICADOS_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_NOCERTIFICADOS_MDTE"].Value.ToString());
                if (Instance.DASqlCommand.Parameters["@SUMA_HISTORICO_MDTE"].Value != null)
                    resumen.SUMA_HISTORICO_MDTE = int.Parse(Instance.DASqlCommand.Parameters["@SUMA_HISTORICO_MDTE"].Value.ToString());

                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllWorkersLocal_IFechaEmpDivision_Informes(ref WorkersLocal parametros)
        {
            DataSet ret_ds = null;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_IFECHAEMPDIVISION_INFORMES_CTTA");

                Instance.DAAgregarParametro("@DIVISION", parametros.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", parametros.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO", parametros.CERT, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TEMP", parametros.TEMP, SqlDbType.NVarChar, 1, ParameterDirection.Input);

                Instance.DAAgregarParametro("@CAMPOS_REPORT", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CAMPOS_CONDUCCION", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CAMPOS_DOC", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CAMPOS_FEC", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);

                ret_ds = Instance.DAExecuteDataSet();

                if (Instance.DASqlCommand.Parameters["@CAMPOS_REPORT"].Value != null)
                    parametros.CAMPOS_REPORT = Instance.DASqlCommand.Parameters["@CAMPOS_REPORT"].Value.ToString();
                if (Instance.DASqlCommand.Parameters["@CAMPOS_CONDUCCION"].Value != null)
                    parametros.CAMPOS_CONDUCCION = Instance.DASqlCommand.Parameters["@CAMPOS_CONDUCCION"].Value.ToString();
                if (Instance.DASqlCommand.Parameters["@CAMPOS_DOC"].Value != null)
                    parametros.CAMPOS_DOC = Instance.DASqlCommand.Parameters["@CAMPOS_DOC"].Value.ToString();
                if (Instance.DASqlCommand.Parameters["@CAMPOS_FEC"].Value != null)
                    parametros.CAMPOS_FEC = Instance.DASqlCommand.Parameters["@CAMPOS_FEC"].Value.ToString();

                return ret_ds;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<WorkersLocal> GetAllWorkersLocal_IFechaFuncDivision_Informes(ref WorkersLocal parametros)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_IFECHAFUNCDIVISION_INFORMES_CTTA");

                Instance.DAAgregarParametro("@DIVISION", parametros.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", parametros.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@AUTOR", parametros.AUTOR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERT", parametros.CERT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TEMP", parametros.TEMP, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OPCION", parametros.OPCION, SqlDbType.Int, 8, ParameterDirection.Input);

                Instance.DAAgregarParametro("@TITULO", parametros.TITULO, SqlDbType.NVarChar, 50, ParameterDirection.Output);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WorkersLocal();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        if (item.RUT != null)
                            item.RUT_COD = Utils.strRut(item.RUT);
                        items.Add(item);
                    }
                }

                if (Instance.DASqlCommand.Parameters["@TITULO"].Value != null)
                    parametros.TITULO = Instance.DASqlCommand.Parameters["@TITULO"].Value.ToString();

                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllWorkersLocal_IFechaFuncDivisionOST_Informes(ref WorkersLocal parametros)
        {
            DataSet ret_ds = null;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_IFECHAFUNCDIVISIONOST_INFORMES_CTTA");

                Instance.DAAgregarParametro("@DIVISION", parametros.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", parametros.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", parametros.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO", parametros.CERT, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                Instance.DAAgregarParametro("@CAMPOS_REPORT", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CAMPOS_CONDUCCION", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CAMPOS_DOC", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CAMPOS_FEC", "", SqlDbType.NVarChar, 500, ParameterDirection.Output);

                ret_ds = Instance.DAExecuteDataSet();

                if (Instance.DASqlCommand.Parameters["@CAMPOS_REPORT"].Value != null)
                    parametros.CAMPOS_REPORT = Instance.DASqlCommand.Parameters["@CAMPOS_REPORT"].Value.ToString();
                if (Instance.DASqlCommand.Parameters["@CAMPOS_CONDUCCION"].Value != null)
                    parametros.CAMPOS_CONDUCCION = Instance.DASqlCommand.Parameters["@CAMPOS_CONDUCCION"].Value.ToString();
                if (Instance.DASqlCommand.Parameters["@CAMPOS_DOC"].Value != null)
                    parametros.CAMPOS_DOC = Instance.DASqlCommand.Parameters["@CAMPOS_DOC"].Value.ToString();
                if (Instance.DASqlCommand.Parameters["@CAMPOS_FEC"].Value != null)
                    parametros.CAMPOS_FEC = Instance.DASqlCommand.Parameters["@CAMPOS_FEC"].Value.ToString();

                return ret_ds;
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion

        #region [ Informes ]

        public ObservableCollection<WorkersLocal> GetWorkers_GridEmpresas_FichaRut_InformeConsultaRapidaCtta(WorkersLocal Item)
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_GRID_EMPRESAS_FICHARUT_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        #region [ Metodos ]

        public bool SaveWorkersLocalLaboralesCtta(string RUT, string EMPRESA, string DIVISION)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_UPDATE_LABORALES_CTTA");

                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool BloquearWorkersLocalLaboralesCtta(string RUT, string USUARIO, string DIVISION, int LOTE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_UPDATE_BLOQUEO_LABORALES_CTTA");

                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOTE", LOTE, SqlDbType.Int, 4, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }

        }
        public bool SaveWorkersLocalPasesFuncionario_Ctta(WorkersLocal WorkersLocal)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_INSERT_PASES_FUNCIONARIOS_CTTA");

                Instance.DAAgregarParametro("@RUT", WorkersLocal.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", WorkersLocal.DIVCOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", WorkersLocal.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ func_getdatos V3 ]

        public WorkersLocal GetWorkersLocalSelectByRut(string RUT, string DIVISION)
        {
            try
            {
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_SELECT_BY_RUT_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, -1, ParameterDirection.Input);
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
    }
}
