
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
    public partial class DAComprobante_Sueldo
    {
        #region [ Consultas ]
        public ObservableCollection<Comprobante_Sueldo> GetAllComprobanteSueldo_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Comprobante_Sueldo> items = new ObservableCollection<Comprobante_Sueldo>();
                Comprobante_Sueldo item = new Comprobante_Sueldo();
                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Comprobante_Sueldo();
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

        public Comprobante_Sueldo GetOneComprobanteSueldo_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                Comprobante_Sueldo item = new Comprobante_Sueldo();
                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
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

        public Comprobante_Sueldo GetOneComprobanteSueldo_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                Comprobante_Sueldo item = new Comprobante_Sueldo();
                //V4MVC_COMPROBANTE_SUELDO_SELECT_ONE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
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

        public Comprobante_Sueldo GetOneComprobanteSueldo_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                Comprobante_Sueldo item = new Comprobante_Sueldo();
                //V4MVC_COMPROBANTE_SUELDO_SELECT_ONE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_SELECT_ONE_V3_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
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
        public bool InsertComprobanteSueldo_ControlLaboralCtta(Comprobante_Sueldo model, out int RET_CODE)
        {
            try
            {
                RET_CODE = -1;

                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
            { throw ex; }
        }
        public bool UpdateComprobanteSueldo_ControlLaboralCtta(Comprobante_Sueldo model, out int RET_CODE)
        {
            try
            {
                RET_CODE = -1;

                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_UPDATE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
        public bool UpdateComprobanteSueldo_v3_ControlLaboralCtta(Comprobante_Sueldo model)
        {
            try
            {
                //V4MVC_COMPROBANTE_SUELDO_UPDATE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_UPDATE_V3_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID", model.ID, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

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

        public bool DelComprobanteSueldoDispFile_ControlLaboralCtta(ref Comprobante_Sueldo modelo)
        {
            try
            {
                //V4MVC_COMPROBANTE_SUELDO_UPDATE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_UPDATE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", modelo.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", modelo.ID, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
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

        public bool DelComprobanteSueldo_ControlLaboralCtta(ref Comprobante_Sueldo modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COMPROBANTE_SUELDO_DELETE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", modelo.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
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
        #endregion
    }
}
	