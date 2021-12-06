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


        #endregion

        #region [ Metodos ]
        public bool SaveFechasWorkersLocal_Mdte(string RUT, int ID_DOC_FEC, string DIVISION, string EMPRESA, string FECHA, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_UPSERT_SET_FECHA_WORKER_LOCAL_MDTE");
                Instance.DAAgregarParametro("@ID_DOC_FEC", ID_DOC_FEC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        public bool SaveFechasDocs_Fec_Workers_Mdte(ref Docs_Fec_Workers docs_Fec_Workers)
        {
            try
            { 
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_INSERT_MDTE");
                Instance.DAAgregarParametro("@PATENTE", docs_Fec_Workers.PATENTE, SqlDbType.NVarChar,10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC_FEC", docs_Fec_Workers.ID_DOC_FEC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", docs_Fec_Workers.DIVISION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", docs_Fec_Workers.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", docs_Fec_Workers.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", docs_Fec_Workers.FECHA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                /*
                 PATENTE	NVARCHAR(10)	= NULL
,@ID_DOC	INT				= NULL
,@DIVCOD	NVARCHAR(5)	= NULL
,@EMPRESA	NVARCHAR(10)	= NULL
,@USUARIO	NVARCHAR(10)	= NULL
,@FECHA	
                 
                 
                 
                 */
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

        #endregion





        #region [ func_getdatos V3 ]

        #endregion

    }
}
