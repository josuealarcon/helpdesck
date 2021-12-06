
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
    public partial class DAA056_Form30
    {
        #region [ Consultas ]
        public ObservableCollection<A056_Form30> GetAllFormF30_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<A056_Form30> items = new ObservableCollection<A056_Form30>();
                A056_Form30 item = new A056_Form30();
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A056_Form30();
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

        public A056_Form30 GetOneFormF30_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                A056_Form30 item = new A056_Form30();
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public A056_Form30 GetOneFormF30_v2_ControlLaboralCtta(int ID_CERTIFICADO)
        {
            try
            {
                A056_Form30 item = new A056_Form30();
                //V4MVC_A056_FORM30_SELECT_ONE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_CERTIFICADO", ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(Guid ID)
        {
            try
            {
                A056_Form30 item = new A056_Form30();
                //V4MVC_A056_FORM30_SELECT_ONE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_SELECT_ONE_V3_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
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

        public A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int CERTIFICADO_ID)
        {
            try
            {
                A056_Form30 item = new A056_Form30();
                //V4MVC_A056_FORM30_SELECT_ONE4_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_SELECT_ONE_V4_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTIFICADO_ID", CERTIFICADO_ID, SqlDbType.Int, 8, ParameterDirection.Input);
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
        public List<int> InsertFormF30_ControlLaboralCtta(A056_Form30 model, out int RET_CODE, out int ID_CERTIFICADO)
        {
            try
            { 
                RET_CODE = -1;
                ID_CERTIFICADO = 0;
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INSPECCION", model.INSPECCION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANIO", model.ANIO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTIFICADO", model.CERTIFICADO, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", model.CLAVE, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", model.REGION, SqlDbType.NVarChar, 3, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VIGENCIA", model.VIGENCIA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MULT_NEJ", model.MULT_NEJ, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MULT_EJ", model.MULT_EJ, SqlDbType.Int, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SANC_6M", model.SANC_6M, SqlDbType.Int, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SANC_12M", model.SANC_12M, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DP_NRO", model.DP_NRO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DP_MTO_UTM", model.DP_MTO_UTM, SqlDbType.Float, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DP_MTO_PESO", model.DP_MTO_PESO, SqlDbType.Int, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RM_NRO", model.RM_NRO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RM_MTO_PESO", model.RM_MTO_PESO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET_CODE", RET_CODE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Output);

                var exec_recs = Instance.DAExecuteNonQuery();
                List<int> LISTAINT = new List<int>();
                if (Instance.DASqlCommand.Parameters["@RET_CODE"].Value != null)
                {
                    RET_CODE = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_CODE"].Value.ToString());
                    LISTAINT.Insert(0, RET_CODE);
                    ID_CERTIFICADO = Int32.Parse(Instance.DASqlCommand.Parameters["@ID_CERTIFICADO"].Value.ToString());
                    LISTAINT.Insert(1, ID_CERTIFICADO);
                }

                return (LISTAINT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public List<int> UpdateFormF30_ControlLaboralCtta(A056_Form30 model, out int RET_CODE, out int ID_CERTIFICADO)
        {
            try
            {
                RET_CODE = -1;
                ID_CERTIFICADO = 0;
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_UPDATE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                Instance.DAAgregarParametro("@INSPECCION", model.INSPECCION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANIO", model.ANIO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", model.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTIFICADO", model.CERTIFICADO, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", model.CLAVE, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", model.REGION, SqlDbType.NVarChar, 3, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VIGENCIA", model.VIGENCIA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MULT_NEJ", model.MULT_NEJ, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MULT_EJ", model.MULT_EJ, SqlDbType.Int, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SANC_6M", model.SANC_6M, SqlDbType.Int, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SANC_12M", model.SANC_12M, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DP_NRO", model.DP_NRO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DP_MTO_UTM", model.DP_MTO_UTM, SqlDbType.Float, 16, ParameterDirection.Input);

                Instance.DAAgregarParametro("@DP_MTO_PESO", model.DP_MTO_PESO, SqlDbType.Int, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RM_NRO", model.RM_NRO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RM_MTO_PESO", model.RM_MTO_PESO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", model.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET_CODE", RET_CODE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@ID_CERTIFICADO_", ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Output);

                var exec_recs = Instance.DAExecuteNonQuery();
                List<int> LISTAINT = new List<int>();
                if (Instance.DASqlCommand.Parameters["@RET_CODE"].Value != null)
                {
                    RET_CODE = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_CODE"].Value.ToString());
                    LISTAINT.Insert(0, RET_CODE);
                    ID_CERTIFICADO = Int32.Parse(Instance.DASqlCommand.Parameters["@ID_CERTIFICADO"].Value.ToString());
                    LISTAINT.Insert(1, ID_CERTIFICADO);
                }

                return (LISTAINT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool UpdateFormF30_v3_ControlLaboralCtta(A056_Form30 model)
        {
            try
            {
                //V4MVC_A056_FORM30_UPDATE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_UPDATE_V3_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID", model.ID, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", model.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);

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

        public bool DelFormF30DispFile_ControlLaboralCtta(ref A056_Form30 modelo)
        {
            try
            {
                //V4MVC_A056_FORM30_UPDATE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_UPDATE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", modelo.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public bool DelFormF30_ControlLaboralCtta(ref A056_Form30 modelo)
        {
            try
            {

                Instance.DAAsignarProcedure("V4MVC_A056_FORM30_DELETE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", modelo.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
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
	