using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Microsoft.SqlServer.Server;

namespace V4mvc.DataAccess
{
    public partial class DAWorkers
    {
        #region [ Consultas ]

        public ObservableCollection<Workers> GetAllWorkersCtta(String IDEMPRESA)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_LIST_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> BuscarFuncionarios(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String sortCOLUMN, String sortDIRECTION,string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_BUSCADORCTTA");
                Instance.DAAgregarParametro("@IDISPLAYSTART", iDisplayStart, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYLENGTH", iDisplayLength, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_RUT", searchRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_NOMBRES", searchNOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_APELLIDOS", searchAPELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_EMPRESA", searchEMPRESA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_COLUMN", sortCOLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_DIRECTION", sortDIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers BuscarFuncionarios_NumRegistros(String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, string IDEMPRESA)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_COUNT_BUSCADORCTTA");
                Instance.DAAgregarParametro("@SEARCH_RUT", searchRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_NOMBRES", searchNOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_APELLIDOS", searchAPELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_EMPRESA", searchEMPRESA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { throw new Exception("No se encontro el registro."); }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> BuscarFuncionariosPases(ref JqueryDatatableParam param)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_BUSCADORPASES_CTTA");
                Instance.DAAgregarParametro("@IDISPLAYSTART", param.iDisplayStart, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYLENGTH", param.iDisplayLength, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_RUT", param.sSearch_0, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_NOMBRES", param.sSearch_1, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_APELLIDOS", param.sSearch_2, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_COLUMN", param.iSortCol_0, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_DIRECTION", param.sSortDir_0, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", param.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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
                param.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> WorkersDatatablesEnterpriseCtta(string IDEMPRESA,Int32 iDisplayStart, Int32 iDisplayLength, string searchRUT, string searchNOMBRES, string searchAPELLIDOS, string sortCOLUMN, string sortDIRECTION)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_DATATABLES_ENTERPRISE_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYSTART", iDisplayStart, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYLENGTH", iDisplayLength, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_RUT", searchRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_NOMBRES", searchNOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_APELLIDOS", searchAPELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_COLUMN", sortCOLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_DIRECTION", sortDIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers WorkersDatatablesEnterpriseCountCtta(string IDEMPRESA, string RUT, string NOMBRES, string APELLIDOS)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_DATATABLES_ENTERPRISE_COUNT_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { throw new Exception("No se encontro el registro."); }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> WorkersDatatablesBusesReserva(Int32 iDisplayStart, Int32 iDisplayLength, String searchRUT, String searchNOMBRES, String searchAPELLIDOS, String searchEMPRESA, String searchOST, String searchIDEMPRESA, String sortCOLUMN, String sortDIRECTION)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_BUSESRESERVA_SELECT_DATATABLES");
                Instance.DAAgregarParametro("@IDISPLAYSTART", iDisplayStart, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYLENGTH", iDisplayLength, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_RUT", searchRUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_NOMBRES", searchNOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_APELLIDOS", searchAPELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_EMPRESA", searchEMPRESA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_OST", searchOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_IDEMPRESA", searchIDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_COLUMN", sortCOLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_DIRECTION", sortDIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers BuscarDuenioMixto(string RUT, string TIPO)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_MIXED_VEHICULO_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", TIPO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        item = null;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorkers_PasesCtta(string RUT, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_ONE_PASES_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDPASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_INI", FEC_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_FIN", FEC_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PASE", TIPO_PASE, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        item = null;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetOneWorker_ContratOSTCtta(string RUT)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_ONE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        item = null;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> GetAllWorkersEnterpriseCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_ENTERPRISE_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> SaveReservas_ExsicoCtta(string IDEMPRESA, string USUARIO, string LIST_RUT, string FECHARES, string HORAINICIO, string HORATERMINO, Decimal TIPO)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_RESERVAS_EXSICO_INSERT_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LIST_RUT", LIST_RUT, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHARES", FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORAINICIO", HORAINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORATERMINO", HORATERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", TIPO, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Workers GetWorkersExisteNominaCtta(string RUT)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_EXISTENOMINA_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        item = null;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Informes ]
        public ObservableCollection<Workers> GetWorkersInformeConsultaRapidaCtta(Workers Item)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Workers> GetWorkers_Grid_AdminColaboradorResumen_InformeConsultaRapidaCtta(Workers Item)
        {
            try
            {
                ObservableCollection<Workers> items = new ObservableCollection<Workers>();
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_GRID_ADMINCOLABORADORRESUMEN_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool setWorkersDatos(string RUT, string EMPRESA, string FECHA_FINIQ, string USUARIO, string DIVCOD, Guid ARCHIVO, string OBSERVACION)
        {
            bool done = false;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_SET_WORKER_DATOS");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_FINIQ", FECHA_FINIQ, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ARCHIVO", ARCHIVO, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION", OBSERVACION, SqlDbType.NVarChar, 500, ParameterDirection.Input);
                done = Instance.DAExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            { throw ex; }
            return done;
        }

        public Workers GetOneDatosPersonalesCtta(string IDEMPRESA, string RUT)
        {
            try
            {
                Workers item = new Workers();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_DATOSPERSONALES_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public bool SaveWorkersLaboralesCtta(ref Workers item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_LABORALES_CTTA");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CCOSTO", item.CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@GSANGRE", item.GSANGRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ROL", item.ROL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersPersonalesCtta(ref Workers item)
        {

            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_WORKERS_INSERT_PERSONALES_CTTA");
                            Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_PERSONALES_CTTA");
                            Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@APELLIDOS", item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHNACIM", item.FECHNACIM, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@SEXO", item.SEXO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                    }


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

        public bool SaveWorkersCovidDI(ref Workers Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_COVID_DI");
                Instance.DAAgregarParametro("@TIPODOC", Item.TIPODOC, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHNACIM", Item.FECHNACIM, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEXO", Item.SEXO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAIL", Item.EMAIL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OCUPACION", Item.OCUPACION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOSEGURO", Item.TIPOSEGURO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEGURO", Item.SEGURO, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCovidF00(ref Workers Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_COVID_F00");
                Instance.DAAgregarParametro("@TIPODOC", Item.TIPODOC, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHNACIM", Item.FECHNACIM, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEXO", Item.SEXO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAIL", Item.EMAIL, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCovidF100(ref Workers Item) {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_COVID_F100");
                Instance.DAAgregarParametro("@TIPODOC", Item.TIPODOC, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEXO", Item.SEXO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCovidF200(ref Workers Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_COVID_F200");
                Instance.DAAgregarParametro("@TIPODOC", Item.TIPODOC, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEXO", Item.SEXO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAIL", Item.EMAIL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OCUPACION", Item.OCUPACION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOSEGURO", Item.TIPOSEGURO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEGURO", Item.SEGURO, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCovidF300(ref Workers Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_COVID_F300");
                Instance.DAAgregarParametro("@TIPODOC", Item.TIPODOC, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersNewEnterpriseCTTA(ref Workers item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_INSERT_NEWENTERPRISECTTA");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDatosPersonalesCtta(ref Workers item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_DATOSPERSONALES_CTTA");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CORREOELECTRONICO", item.EMAIL, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CELULAR", item.CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FONO", item.FONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FONOHELP", item.FONOHELP, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PAIS", item.PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUNA", item.COMUNA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ZONA", item.ZONA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECCION", item.DIRECCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAILOLD", item.EMAILOLD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveWorkersCursos(ref Workers Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_INSERT_CURSOS_CTTA");
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool Save_Workers_AprobacionSubContrato( Workers Item)
        {
            try
            {              
                Instance.DAAsignarProcedure("V4MVC_WORKERS_INSERT_APROBACION_SUBCONTRATOS_CTTA");
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", Item.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", Item.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAIL", Item.EMAIL, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool updateWorkersEmailBusesReservas_Ctta(string EMAIL, string RUT )
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_UPDATE_EMAIL_BUSES_RESERVA_CTTA");
                Instance.DAAgregarParametro("@EMAIL", EMAIL, SqlDbType.NVarChar, 60, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);

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
