
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
    public partial class DAWorkerZonaPase
    {
        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        public bool SaveWorkerZonaPase_PasesCtta(WorkerZonaPase zona)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_UPSERT_PASES_CTTA");

                Instance.DAAgregarParametro("@ID_PASE", zona.IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", zona.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCAL", zona.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", zona.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", zona.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkerZonaPaseAcceso_PasesCtta(WorkerZonaPase zona)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_UPSERTACCESO_PASES_CTTA");

                Instance.DAAgregarParametro("@ID_PASE", zona.IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", zona.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCAL", zona.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", zona.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", zona.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", zona.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelWorkerZonaPase_PasesCtta(int IDPASE, string RUT, string concat_locales, string ESTAVACIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_DELETE_PASES_CTTA");

                Instance.DAAgregarParametro("@ID_PASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CS_LOCALES_EXISTENTES", concat_locales, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTAVACIO", ESTAVACIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool DelWorkerZonaPaseAccesos_PasesCtta(int IDPASE, string RUT, string concat_locales, string ESTAVACIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_DELETE_PASESACCESO_CTTA");

                Instance.DAAgregarParametro("@ID_PASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CS_LOCALES_EXISTENTES", concat_locales, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTAVACIO", ESTAVACIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	