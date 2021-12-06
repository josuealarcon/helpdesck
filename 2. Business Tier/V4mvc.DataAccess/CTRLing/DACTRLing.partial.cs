using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DACTRLing
    {
        #region [ Consultas ]
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_CTRLACCESORESUMEN");
                Instance.DAAgregarParametro("@LOCAL", Item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OPCION", Item.OPCION, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_INF1, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_INF1, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUTINGRESO", Item.RUTINGRESO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", Item.PATENTE, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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

        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diatotal(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_CTRLACCESORESUMEN_DIATOTAL");
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCAL", Item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CAMPO", Item.CAMPO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUTINGRESO", Item.RUTINGRESO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", Item.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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

        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_CensoAccesos(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_CENSOACCESOS");
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_INF2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_INF2, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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
        public DataSet Get_WC3_Vista_Ctrling_Informe_CensoAccesos_Detalle(CTRLing Item)
        {
            try
            {
                DataSet ds = new DataSet();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_CENSOACCESOS_DETALLE");
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                ds = Instance.DAExecuteDataSet();               
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_AccesosZonasControladas(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_ACCESOSZONASCONTROLADAS");
                Instance.DAAgregarParametro("@LOCAL", Item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OPCION", Item.OPCION, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_INF3, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_INF3, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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
        
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diatotal(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_ACCESOSZONASCONTROLADAS_DIATOTAL");
                Instance.DAAgregarParametro("@LOCAL", Item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAINI", Item.FECHAINI_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", Item.FECHAFIN_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CAMPO", Item.CAMPO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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
        public ObservableCollection<CTRLing> GetCTRLing_Grid_Movimiento_IngSal_MesActual_InformeFuncionariosCtta(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_CTRLING_SELECT_MOVIMIENTO_INGSAL_MESACTUAL_INFORMEFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUTINGRESO", Item.RUTINGRESO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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
        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diaresumen(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_CTRLACCESORESUMEN_DIARESUMEN");
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCAL", Item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", Item.FECHA_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUTINGRESO", Item.RUTINGRESO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", Item.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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

        public ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diaresumen(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_GET_WC3_VISTA_CTRLING_INFORME_ACCESOSZONASCONTROLADAS_DIARESUMEN");
                Instance.DAAgregarParametro("@LOCAL", Item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", Item.FECHA_FILTER, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", Item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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
        public ObservableCollection<CTRLing> GetCTRLing_Grid_Movimiento_IngSal_MesActual_Detalle_InformeFuncionariosCtta(CTRLing Item)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_CTRLING_SELECT_MOVIMIENTO_INGSAL_MESACTUAL_DETALLE_INFORMEFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUTINGRESO", Item.RUTINGRESO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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
    }
}