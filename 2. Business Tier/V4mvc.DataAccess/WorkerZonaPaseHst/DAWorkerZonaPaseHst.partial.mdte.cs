
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
    public partial class DAWorkerZonaPaseHst
    {
        #region [ Consultas ]

        #endregion

        #region [ Metodos ]

        public bool SaveWorkerZonaPaseHst_PasesMdte(int IDPASE, string RUT, string ID_EMPRESA)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_HST_INSERT_PASES_MDTE");

                Instance.DAAgregarParametro("@ID_PASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

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
	