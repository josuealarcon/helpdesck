
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
    public partial class DAPlanilla_Cotizacion
    {
        #region [ Consultas ]
        public ObservableCollection<Planilla_Cotizacion> GetAllPlanillaCotizacion_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Planilla_Cotizacion> items = new ObservableCollection<Planilla_Cotizacion>();
                Planilla_Cotizacion item = new Planilla_Cotizacion();
                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Planilla_Cotizacion();
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

        public Planilla_Cotizacion GetOnePlanillaCotizacion_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                Planilla_Cotizacion item = new Planilla_Cotizacion();
                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public Planilla_Cotizacion GetOnePlanillaCotizacion_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                Planilla_Cotizacion item = new Planilla_Cotizacion();
                //V4MVC_PLANILLA_COTIZACION_SELECT_ONE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public Planilla_Cotizacion GetOnePlanillaCotizacion_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST)
        {
            try
            {
                Planilla_Cotizacion item = new Planilla_Cotizacion();
                //V4MVC_PLANILLA_COTIZACION_SELECT_ONE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_SELECT_ONE_V3_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        #region [ Metodos ]

        public bool InsertPlanillaCotizacion_ControlLaboralCtta(Planilla_Cotizacion model, out int RET_CODE)
        {
            try
            {
                RET_CODE = -1;

                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MONTOIMP", model.MONTOIMP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CANTFUNC", model.CANTFUNC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET_CODE", RET_CODE, SqlDbType.Int, 8, ParameterDirection.Output);

                var exec_recs = Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@RET_CODE"].Value != null)
                {
                    RET_CODE = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_CODE"].Value.ToString());
                }

                if (exec_recs > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdatePlanillaCotizacion_ControlLaboralCtta(Planilla_Cotizacion model, out int RET_CODE)
        {
            try
            {
                RET_CODE = -1;

                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_UPDATE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET_CODE", RET_CODE, SqlDbType.Int, 8, ParameterDirection.Output);

                var exec_recs = Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@RET_CODE"].Value != null)
                {
                    RET_CODE = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_CODE"].Value.ToString());
                }

                return !(RET_CODE > 0);
            }
            catch (Exception ex)
            { throw ex; }
        }


        public bool UpdatePlanillaCotizacion_v3_ControlLaboralCtta(Planilla_Cotizacion model)
        {
            try
            {
                //V4MVC_PLANILLA_COTIZACION_UPDATE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_UPDATE_V3_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID", model.ID, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MONTOIMP", model.MONTOIMP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CANTFUNC", model.CANTFUNC, SqlDbType.Int, 8, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DelPlanillaCotizacion_ControlLaboralCtta(ref Planilla_Cotizacion modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_DELETE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", modelo.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", modelo.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", modelo.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", modelo.TIPO_DOCUMENTO_ID, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", modelo.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DISPUTA_ID", modelo.DISPUTA_ID, SqlDbType.Int, 8, ParameterDirection.Input);

                Instance.DAAgregarParametro("@DISPUTA_EXISTE", modelo.DISPUTA_EXISTE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@DISPUTA_EMPRESA", modelo.DISPUTA_EMPRESA, SqlDbType.NVarChar, 12, ParameterDirection.Output);
                Instance.DAAgregarParametro("@DISPUTA_FECHA", modelo.DISPUTA_FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_EXISTE"].Value != null)
                    {
                        modelo.DISPUTA_EXISTE = Int32.Parse(Instance.DASqlCommand.Parameters["@DISPUTA_EXISTE"].Value.ToString());
                    }
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_EMPRESA"].Value != null)
                    {
                        modelo.DISPUTA_EMPRESA = Instance.DASqlCommand.Parameters["@DISPUTA_EMPRESA"].Value.ToString();
                    }
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_FECHA"].Value != null)
                    {
                        modelo.DISPUTA_FECHA = Instance.DASqlCommand.Parameters["@DISPUTA_FECHA"].Value.ToString();
                    }
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelPlanillaCotizacionDispFile_ControlLaboralCtta(ref Planilla_Cotizacion modelo)
        {
            try
            {

                Instance.DAAsignarProcedure("V4MVC_PLANILLA_COTIZACION_UPDATE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", modelo.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", modelo.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", modelo.ID, SqlDbType.UniqueIdentifier, 32, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", modelo.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", modelo.OST, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DISPUTA_ID", modelo.DISPUTA_ID, SqlDbType.Int, 8, ParameterDirection.Input);
                
                Instance.DAAgregarParametro("@DISPUTA_EXISTE", modelo.DISPUTA_EXISTE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@DISPUTA_EMPRESA", modelo.DISPUTA_EMPRESA, SqlDbType.NVarChar, 12, ParameterDirection.Output);
                Instance.DAAgregarParametro("@DISPUTA_FECHA", modelo.DISPUTA_FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_EXISTE"].Value != null)
                    {
                        modelo.DISPUTA_EXISTE = Int32.Parse(Instance.DASqlCommand.Parameters["@DISPUTA_EXISTE"].Value.ToString());
                    }
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_EMPRESA"].Value != null)
                    {
                        modelo.DISPUTA_EMPRESA = Instance.DASqlCommand.Parameters["@DISPUTA_EMPRESA"].Value.ToString();
                    }
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_FECHA"].Value != null)
                    {
                        modelo.DISPUTA_FECHA = Instance.DASqlCommand.Parameters["@DISPUTA_FECHA"].Value.ToString();
                    }
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
	