
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
    public partial class DA_F29
    {
        #region [ Consultas ]
        public ObservableCollection<_F29> GetAllF29_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<_F29> items = new ObservableCollection<_F29>();
                _F29 item = new _F29();
                Instance.DAAsignarProcedure("V4MVC__F29_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new _F29();
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

        public _F29 GetOneFormF29_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                _F29 item = new _F29();
                Instance.DAAsignarProcedure("V4MVC__F29_SELECT_ONE_CONTROLLABORAL_CTTA");
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

        public _F29 GetOneFormF29_v2_ControlLaboralCtta(string EMPRESA, string PERIODO)
        {
            try
            {
                _F29 item = new _F29();
                //V4MVC__F29_SELECT_ONE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC__F29_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
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

        public _F29 GetOneFormF29_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO)
        {
            try
            {
                _F29 item = new _F29();
                //V4MVC__F29_SELECT_ONE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC__F29_SELECT_ONE_V3_CONTROLLABORAL_CTTA");
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
        public bool InsertFormF29_ControlLaboralCtta(_F29 model, out int RET_CODE)
        {
            try
            {
                RET_CODE = -1;

                Instance.DAAsignarProcedure("V4MVC__F29_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VENTAS", model.VENTAS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMPRAS", model.COMPRAS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PPM", model.PPM, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REMANENTE", model.REMANENTE, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IRENTA", model.IRENTA, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BHONORARIOS", model.BHONORARIOS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IMP_PAGADO", model.IMP_PAGADO, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REMMESANT", model.REMMESANT, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MULTAS", model.MULTAS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADOCERT", model.ESTADOCERT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@POSTERGADO", model.POSTERGADO, SqlDbType.Int, 8, ParameterDirection.Input);
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
        public bool UpdateFormF29_ControlLaboralCtta(_F29 model, out int RET_CODE)
        {
            try
            {
                RET_CODE = -1;

                Instance.DAAsignarProcedure("V4MVC__F29_UPDATE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VENTAS", model.VENTAS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMPRAS", model.COMPRAS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PPM", model.PPM, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REMANENTE", model.REMANENTE, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IRENTA", model.IRENTA, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BHONORARIOS", model.BHONORARIOS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IMP_PAGADO", model.IMP_PAGADO, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REMMESANT", model.REMMESANT, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MULTAS", model.MULTAS, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADOCERT", model.ESTADOCERT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
        public bool UpdateFormF29_v3_ControlLaboralCtta(_F29 model)
        {
            try
            {
                //V4MVC__F29_UPDATE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC__F29_UPDATE_V3_CONTROLLABORAL_CTTA");
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

        public bool DelFormF29DispFile_ControlLaboralCtta(ref _F29 modelo)
        {
            try
            {
                //V4MVC__F29_UPDATE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC__F29_UPDATE_V2_CONTROLLABORAL_CTTA");
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

        public bool DelFormF29_ControlLaboralCtta(ref _F29 modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC__F29_DELETE_CONTROLLABORAL_CTTA");
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
	