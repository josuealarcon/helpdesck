using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DAWorkers_Licencias
	{
        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        public bool DeleteWorkersLicenciasConductoresCtta(string RUT)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_LICENCIAS_DELETE_CONDUCTORES_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveWorkersLicenciasConductoresCtta(string RUT, string licencias)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_LICENCIAS_INSERT_CONDUCTORES_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LICENCIAS", licencias, SqlDbType.NVarChar, 200, ParameterDirection.Input);

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
