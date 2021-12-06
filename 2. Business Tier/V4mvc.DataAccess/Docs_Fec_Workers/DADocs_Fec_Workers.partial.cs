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
	public partial class DADocs_Fec_Workers
	{

        #region [ Consultas ]
        public Docs_Fec_Workers GetDocumentacionTransportFechaCtta(string RUT, int ID_DOC_FEC, string DIVCOD, string IDEMPRESA)
        {
            try
            {
                Docs_Fec_Workers item = new Docs_Fec_Workers();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_TRANSPORT_SELECT_FECHADOCUMENTO_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
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
        public Docs_Fec_Workers GetDocumentacionFuncionarioFechaCtta(string RUT, int ID_DOC_FEC, string DIVCOD, string IDEMPRESA)
        {
            try
            {
                Docs_Fec_Workers item = new Docs_Fec_Workers();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_FUNCIONARIO_SELECT_FECHADOCUMENTO_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
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
        public Docs_Fec_Workers GetDocumentacionFechaCtta(string RUT, int ID_DOC_FEC, string DIVCOD, string IDEMPRESA)
        {
            try
            {
                Docs_Fec_Workers item = new Docs_Fec_Workers();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_SELECT_FECHADOCUMENTO_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
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

        public string getFechaWLocal(string RUT, int ID_DOC_FEC, string EMPRESA) {
            string fec_wlocal = string.Empty;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_GET_FECHA_WORKER_LOCAL");
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 8, ParameterDirection.Input);         
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_WLOCAL", string.Empty, SqlDbType.NVarChar, 8, ParameterDirection.InputOutput);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    fec_wlocal = Instance.DASqlCommand.Parameters["@FEC_WLOCAL"].Value.ToString();
                }
            }
            catch (Exception ex)
            { throw ex; }
            return fec_wlocal;
        }

        #endregion

        #region [ Metodos ]
        public bool setFechaWLocal(string RUT, int ID_DOC_FEC, string DIV, string EMPRESA, string FECHA, string USUARIO)
        {

            try
            {
                Instance.DAAsignarProcedure("V4MVC_SET_FECHA_WORKER_LOCAL");
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIV, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAExecuteNonQuery();
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        
        }

        public bool setFechaEmpresa(int ID_DOC_FEC, string EMPRESA, string FECHA)
        {
            bool done = false;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_SET_FECHA_EMPRESA");
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAExecuteNonQuery();
                done = true;
            }
            catch (Exception ex)
            { throw ex; }
            return done;
        }
        #endregion


        #region [ func_getdatos V3 ]

        public Docs_Fec_Workers GetDocs_Fec_Workers_ByIdDocFec(string RUT, string DIVISION, string EMPRESA, int ID_DOCUMENTO, int ID_DOC_FEC, int? COMUN, int? VALIDADO_MAYOR_HOY, int? EMPRESACOMUN)
        {
            try
            {
                Docs_Fec_Workers item = new Docs_Fec_Workers();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_SELECT_BY_ID_DOC_FEC_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOCUMENTO", ID_DOCUMENTO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN", COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO_MAYOR_HOY", VALIDADO_MAYOR_HOY, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESACOMUN", EMPRESACOMUN, SqlDbType.Int, 4, ParameterDirection.Input);
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

    }
}
