using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Microsoft.Practices.EnterpriseLibrary.Data;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DALotePases
	{
        #region [ Consultas ]

        public ObservableCollection<LotePases> GetAllLotePases_PasesCtta(string IDEMPRESA, bool ACTUAL)
        {
            try
            {
                ObservableCollection<LotePases> items = new ObservableCollection<LotePases>();
                LotePases item = new LotePases();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_SELECT_PASES_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTUAL", ACTUAL, SqlDbType.Bit, 1, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LotePases();
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

        public LotePases GetOneLotePases_PasesCtta(int LOTENUM)
        {
            try
            {
                LotePases item = new LotePases();
                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_SELECT_ONE_PASES_CTTA");
                Instance.DAAgregarParametro("@LOTENUM", LOTENUM, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SendPase_PasesCtta(ref LotePases modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_UPDATE_PASES_CTTA");
                Instance.DAAgregarParametro("@LOTENUM", modelo.IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAIL_AUT", modelo.EMAIL_AUT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT_AUT", modelo.RUT_AUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVADO_DELEGADOS_OST", modelo.ACTIVADO_DELEGADO_OST, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET_OK", false, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@JSON_RET", String.Empty, SqlDbType.NVarChar, -1, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@RET_OK"].Value != null)
                    {
                        modelo.RET_OK = Int32.Parse(Instance.DASqlCommand.Parameters["@RET_OK"].Value.ToString());
                    }
                    if (Instance.DASqlCommand.Parameters["@JSON_RET"].Value != null)
                    {
                        modelo.JSON_RET = Instance.DASqlCommand.Parameters["@JSON_RET"].Value.ToString();
                    }
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveLotePases_PasesCtta(string INS_OST, string INS_EMP, string INS_DIVCOD, string INS_FINICIO, string INS_FFINAL, string INS_TPASE, string INS_DESCRIP, string IDEMPRESA, string USUARIO, out int new_id)
        {
            try
            {

                new_id = -1;

                Instance.DAAsignarProcedure("V4MVC_LOTEPASES_INSERT_PASES_CTTA");
                Instance.DAAgregarParametro("@INS_OST", INS_OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INS_EMP", INS_EMP, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INS_DIVCOD", INS_DIVCOD, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INS_FINICIO", INS_FINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INS_FFINAL", INS_FFINAL, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INS_TPASE", INS_TPASE, SqlDbType.NVarChar, 9, ParameterDirection.Input);
                Instance.DAAgregarParametro("@INS_DESCRIP", INS_DESCRIP, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NEW_ID", new_id, SqlDbType.Int, 8, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@NEW_ID"].Value != null)
                    {
                        new_id = int.Parse(Instance.DASqlCommand.Parameters["@NEW_ID"].Value.ToString());
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
