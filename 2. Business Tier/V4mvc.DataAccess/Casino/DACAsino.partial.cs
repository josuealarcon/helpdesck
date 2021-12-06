using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DACasino
    {

        #region [ Consultas ]

        public ObservableCollection<Casino> GetListCasino()
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_SELECT_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoFechasCtta(string FECHAINI, string FECHAFIN)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_FECHAS_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoLocalesCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_LOCALES_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public DataSet GetAllCasinoServicioFecha(ref Casino model)
        {
            try
            {
                DataSet ds = new DataSet();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CASINO_FECHA_LOCAL_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                ds = Instance.DAExecuteDataSet();
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Casino> GetAllCasinoServicioEmpresa(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_SELECT_SERVICIOEMPRESA_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OPTION", model.OPTION, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoServicioLocalCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_SERVICIO_LOCAL_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoServicioLocalFechaCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_LOCAL_SERVICIO_FECHA_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoSubtotalCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_SUBTOTAL_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoTotalCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_TOTAL_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoServicioCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CASINO_SERVICIO_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoServicioDiaCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CASINO_SERVICIO_DIA_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCALES", model.LOCALES, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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
        public ObservableCollection<Casino> GetCasino_Grid_Consumo_Casino_MesActual_InformeFuncionariosCtta(Casino request)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINO_SELECT_CONSUMO_CASINO_MESACTUAL_INFORMEFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", request.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public ObservableCollection<Casino> GetCasinoDetalleCtta(ref Casino model)
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CASINO_FECHA_LOCAL_DETALLE_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCAL", model.LOCAL, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OP", model.OP, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RBNTIPOCONSUMO", model.RBNTIPOCONSUMO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SERVICIO", model.SERVICIO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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
        #region [ Métodos ]

        #endregion

    }
}