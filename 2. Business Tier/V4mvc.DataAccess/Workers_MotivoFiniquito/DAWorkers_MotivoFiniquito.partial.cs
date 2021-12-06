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
	public partial class DAWorkers_MotivoFiniquito
	{
		#region [ Consultas ]
		public bool getMotivoUltimo(string MOTIVO, string RUT, string EMPRESA, int ID_DOC)
        {
            bool result = false;
            int output = -1;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_GET_MOTIVO_ULTIMO");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MOTIVO", MOTIVO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ULTIMO", -1, SqlDbType.Int, 8, ParameterDirection.InputOutput);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if(int.TryParse(Instance.DASqlCommand.Parameters["@ULTIMO"].Value.ToString(), out output)){
                        result = output == 1;
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
            return result;
        }
		#endregion

		#region [ Metodos ]
		public bool SaveWorkerMotivFiniq_FuncionariosCtta(ref Workers_MotivoFiniquito item)
		{
			try
			{

				Instance.DAAsignarProcedure("V4MVC_WORKERS_MOTIVOFINIQUITO_INSERT_FUNCIONARIOS_CTTA");
				Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDARCHIVO", item.IDARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
				Instance.DAAgregarParametro("@MOTIVO", item.MOTIVO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@USRREGISTRA", item.USRREGISTRA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@USRMOD", item.USRMOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
