
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
    public partial class DAA056_Form30_1
    {
        #region [ Consultas ]
        public ObservableCollection<A056_Form30_1> GetAllF301_ControlLaboralCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<A056_Form30_1> items = new ObservableCollection<A056_Form30_1>();
                A056_Form30_1 item = new A056_Form30_1();
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A056_Form30_1();
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

        public A056_Form30_1 GetOneFormF301_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                A056_Form30_1 item = new A056_Form30_1();
                //V4MVC_A056_FORM301_SELECT_ONE4_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_SELECT_ONE_V4_CONTROLLABORAL_CTTA");
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

        public A056_Form30_1 GetOneFormF301_v2_ControlLaboralCtta(int ID_CERTIFICADO)
        {
            try
            {
                A056_Form30_1 item = new A056_Form30_1();
                //V4MVC_A056_FORM301_SELECT_ONE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
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

        public A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(Guid ID)
        {
            try
            {
                A056_Form30_1 item = new A056_Form30_1();
                //V4MVC_A056_FORM301_SELECT_ONE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_SELECT_ONE_V3_CONTROLLABORAL_CTTA");
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

        public A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO)
        {
            try
            {
                A056_Form30_1 item = new A056_Form30_1();
                //V4MVC_A056_FORM301_SELECT_ONE4_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_SELECT_ONE_V4_CONTROLLABORAL_CTTA");
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

        public A056_Form30_1 GetOneFormF301_v4_ControlLaboralCtta(string PERIODO, string EMPRESA)
        {
            try
            {
                A056_Form30_1 item = new A056_Form30_1();
                Instance.DAAsignarProcedure("V4MVC_WC3_VISTA_CLABORAL_DC_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
        public A056_Form30_1 GetOneFormF301_v5_ControlLaboralCtta(string PERIODO, string EMPRESA)
        {
            try
            {
                A056_Form30_1 item = new A056_Form30_1();
                Instance.DAAsignarProcedure("V4MVC_WC3_VISTA_CLABORAL_DC_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
        public List<int> InsertFormF301_ControlLaboralCtta(A056_Form30_1 model, out int RET_CODE, out int ID_CERTIFICADO_)
        {
            try
            {
                RET_CODE = 0;
                ID_CERTIFICADO_ = 0;

                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_INSERT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", model.CLAVE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", model.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INSPECCION", model.INSPECCION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANIO", model.ANIO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTIFICADO", model.CERTIFICADO, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO_INI", model.PERIODO_INI, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO_FIN", model.PERIODO_FIN, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRA_DECL", model.TRA_DECL, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRA_DESV", model.TRA_DESV, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRA_VIGE", model.TRA_VIGE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COT_PAG", model.COT_PAG, SqlDbType.NVarChar, 1, ParameterDirection.Input);

                Instance.DAAgregarParametro("@COT_NPAG", model.COT_NPAG, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ADJ_NOM", model.ADJ_NOM, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AP_P", model.IND_AP_P, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AP_MTO", model.IND_AP_MTO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AP_NP", model.IND_AP_NP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AS_P", model.IND_AS_P, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AS_MTO", model.IND_AS_MTO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AS_NP", model.IND_AS_NP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", model.TIPO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                //Instance.DAAgregarParametro("@ID_CERTIFICADO", model.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET_CODE", RET_CODE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@ID_CERTIFICADO_", ID_CERTIFICADO_, SqlDbType.Int, 8, ParameterDirection.Output);



                var exec_recs = Instance.DAExecuteNonQuery();
                List<int> LISTAINT = new List<int>();
                if (Instance.DASqlCommand.Parameters["@RET_CODE"].Value != null)
                {
                    RET_CODE = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_CODE"].Value.ToString());
                    LISTAINT.Insert(0, Convert.ToInt32(RET_CODE));
                    ID_CERTIFICADO_ = Int32.Parse(Instance.DASqlCommand.Parameters["@ID_CERTIFICADO_"].Value.ToString());
                    LISTAINT.Insert(1, Convert.ToInt32(ID_CERTIFICADO_));
                   
                }

                return (LISTAINT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public List<int> UpdateFormF301_ControlLaboralCtta(A056_Form30_1 model, out int RET_CODE, out int ID_CERTIFICADO_)
        {
            try
            {
                RET_CODE = -1;
                ID_CERTIFICADO_ = 0;
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_UPDATE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", model.CLAVE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@REGION", model.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INSPECCION", model.INSPECCION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANIO", model.ANIO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTIFICADO", model.CERTIFICADO, SqlDbType.BigInt, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO_INI", model.PERIODO_INI, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO_FIN", model.PERIODO_FIN, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRA_DECL", model.TRA_DECL, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRA_DESV", model.TRA_DESV, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRA_VIGE", model.TRA_VIGE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COT_PAG", model.COT_PAG, SqlDbType.NVarChar, 1, ParameterDirection.Input);

                Instance.DAAgregarParametro("@COT_NPAG", model.COT_NPAG, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ADJ_NOM", model.ADJ_NOM, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AP_P", model.IND_AP_P, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AP_MTO", model.IND_AP_MTO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AP_NP", model.IND_AP_NP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AS_P", model.IND_AS_P, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AS_MTO", model.IND_AS_MTO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IND_AS_NP", model.IND_AS_NP, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", model.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET_CODE", RET_CODE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@ID_CERTIFICADO_", ID_CERTIFICADO_, SqlDbType.Int, 8, ParameterDirection.Output);

                var exec_recs = Instance.DAExecuteNonQuery();

                List<int> LISTAINT = new List<int>();
                if (Instance.DASqlCommand.Parameters["@RET_CODE"].Value != null)
                {
                    RET_CODE = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_CODE"].Value.ToString());
                    LISTAINT.Insert(0, Convert.ToInt32(RET_CODE));
                    ID_CERTIFICADO_ = Int32.Parse(Instance.DASqlCommand.Parameters["@ID_CERTIFICADO_"].Value.ToString());
                    LISTAINT.Insert(1, Convert.ToInt32(ID_CERTIFICADO_));

                }

                return (LISTAINT);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool UpdateFormF301_v3_ControlLaboralCtta(A056_Form30_1 model)
        {
            try
            {
                //V4MVC_A056_FORM301_UPDATE3_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_UPDATE_V3_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID", model.ID, SqlDbType.UniqueIdentifier, 36, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", model.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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

        public bool DelFormF301_ControlLaboralCtta(ref A056_Form30_1 modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_DELETE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", modelo.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", modelo.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DISPUTA_ID", modelo.DISPUTA_ID, SqlDbType.Int, 8, ParameterDirection.Input);

                Instance.DAAgregarParametro("@DISPUTA_EXISTE", modelo.DISPUTA_EXISTE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@DISPUTA_EMPRESA", modelo.DISPUTA_EMPRESA, SqlDbType.NVarChar, 12, ParameterDirection.Output);
                Instance.DAAgregarParametro("@DISPUTA_FECHA", modelo.DISPUTA_FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@DISPUTA_USUARIO", modelo.DISPUTA_USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Output);

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
                    if (Instance.DASqlCommand.Parameters["@DISPUTA_USUARIO"].Value != null)
                    {
                        modelo.DISPUTA_USUARIO = Instance.DASqlCommand.Parameters["@DISPUTA_USUARIO"].Value.ToString();
                    }
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelFormF301DispFile_ControlLaboralCtta(ref A056_Form30_1 modelo)
        {
            try
            {
                //V4MVC_A056_FORM301_UPDATE2_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_A056_FORM301_UPDATE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", modelo.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", modelo.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", modelo.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", modelo.OST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", modelo.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DISPUTA_ID", modelo.DISPUTA_ID, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_CERTIFICADO", modelo.ID_CERTIFICADO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", modelo.ID, SqlDbType.UniqueIdentifier, 32, ParameterDirection.Input);


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
	