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
    public partial class DAWorkerscasino
    {
        #region [ Consultas ]
        public bool SaveWorkercasino_Ctta(string RUT, string LOCAL, string SERVICIO)
        {
            try
            {

                Instance.DAAsignarProcedure("V4MVC_WORKERSCASINO_INSERT_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LOCAL", LOCAL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SERVICIO", SERVICIO, SqlDbType.NVarChar, 24, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool DeleteWorkerCasino_Ctta(string RUT)
{
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERSCASINO_DELETE_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
