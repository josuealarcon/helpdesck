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
    public partial class DAOST
    {

        #region [ Consultas ]

        public OST GetOneOST_Mdte(string NROOST)
        {
            try
            {
                OST item = new OST();
                Instance.DAAsignarProcedure("V4MVC_OST_MDTE");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
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

        public bool ValidateOST(string NROOST)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_OST_VALIDATE_MDTE");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() > 0 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool GetStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_OST_SELECT_STATUS_MDTE");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() > 0 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool UpdateStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_OST_UPDATE_STATUS_MDTE");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveContratoOST_Mdte(ref OST model)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_OST_SAVE_MDTE");
                Instance.DAAgregarParametro("@NROOST", model.NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", model.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECINICIO", model.FECINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECTERM", model.FECTERM, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECCIERRE", model.FECCIERRE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ALOJA", model.ALOJA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TRANSP", model.TRANSP, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ALIMENT", model.ALIMENT, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMBUST", model.COMBUST, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTACION", model.DOTACION, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTALIM", model.DOTALIM, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FLOTANTE", model.FLOTANTE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTALOJA", model.DOTALOJA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIPOST", model.DESCRIPOST, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", model.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCEXT", model.DESCEXT, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_SECTOR", model.ID_SECTOR, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DEPARTAMENTO", model.ID_DEPARTAMENTO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_TIPO_SECTOR", model.ID_TIPO_SECTOR, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_AVISOESE", model.FECHA_AVISOESE, SqlDbType.DateTime, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAESEFORMAT", model.FECHAESEFORMAT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORAESEFORMAT", model.HORAESEFORMAT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTTRANS", model.DOTTRANS, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESPORADICO", model.ESPORADICO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERMANENTE", model.PERMANENTE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTMAXFAENA", model.DOTMAXFAENA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HOLGDOTACRE", model.HOLGDOTACRE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USRCREACION", model.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADOR", model.VALIDADOR, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTACION_PERM_ACCESO", model.DOTACION_PERM_ACCESO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTACION_ESPO_ACCESO", model.DOTACION_ESPO_ACCESO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTACION_PERM_BUSSES", model.DOTACION_PERM_BUSSES, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTACION_ESPO_BUSSES", model.DOTACION_ESPO_BUSSES, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_INSTALACION_FAENA", model.ID_INSTALACION_FAENA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EDIFICIO_INSTALACION", model.EDIFICIO_INSTALACION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTACION_ESPO_ACCESO_MESES", model.DOTACION_ESPO_ACCESO_MESES, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESACAMO", model.EMPRESACAMO, SqlDbType.NVarChar, 15, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SUBC", model.SUBC, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
