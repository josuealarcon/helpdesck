
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
    public partial class DADocs_OST_Prevencionista
    {
        #region [ Consultas ]
        public Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL, int NUM_SOLICITUD, out int SUBE_DOCUMENTO)
        {
            SUBE_DOCUMENTO = 1;
            try
            {
                Docs_OST_Prevencionista item = new Docs_OST_Prevencionista();
                item.EMPTY = true;
                Instance.DAAsignarProcedure("V4MVC_DOCS_OST_PREVENCIONISTA_SELECT_ONE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NUM_SOLICITUD", NUM_SOLICITUD, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SUBE_DOCUMENTO", 1, SqlDbType.Int, 8, ParameterDirection.Output);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        item.EMPTY = false;
                    }
                }
                if (Instance.DASqlCommand.Parameters["@SUBE_DOCUMENTO"].Value != null)
                {
                    SUBE_DOCUMENTO = int.Parse(Instance.DASqlCommand.Parameters["@SUBE_DOCUMENTO"].Value.ToString());
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs_OST_Prevencionista GetOneDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD)
        {
            try
            {
                Docs_OST_Prevencionista item = new Docs_OST_Prevencionista();
                //V4MVC_DOCS_OST_PREVENCIONISTA_SELECT_ONE2_CONTRATOST_CTTA
                Instance.DAAsignarProcedure("V4MVC_DOCS_OST_PREVENCIONISTA_SELECT_ONE_V2_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NUM_SOLICITUD", NUM_SOLICITUD, SqlDbType.Int, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        throw new Exception("Custom Message : Register Not Found");
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public bool SaveDocsOSTPrevencionista_ContratOSTCtta(Docs_OST_Prevencionista prev)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_OST_PREVENCIONISTA_UPDATE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NUM_SOLICITUD", prev.NUM_SOLICITUD, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", prev.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", prev.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", prev.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", prev.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FONO", prev.FONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAIL", prev.EMAIL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", prev.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO_ANTERIOR", prev.ESTADO_ANTERIOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_ARCHIVO", prev.ID_ARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelDocsOSTPrevencionista_ContratOSTCtta(int NUM_SOLICITUD, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_OST_PREVENCIONISTA_DELETE_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NUM_SOLICITUD", NUM_SOLICITUD, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                
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
	