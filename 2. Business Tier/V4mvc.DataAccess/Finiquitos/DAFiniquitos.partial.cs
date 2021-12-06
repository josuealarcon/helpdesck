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
	public partial class DAFiniquitos
	{
		#region [ Consultas ]
		#endregion

		#region [ Metodos ]
		public bool AprobarFiniquitoQv_FuncionariosCtta(string RUT, string USUARIO, string EMPRESA, ref string parametros_mail) {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_HOTEL_RESERVA_UPDATE_FUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@JSON_MAIL_DATA", String.Empty, SqlDbType.NVarChar, 4000, ParameterDirection.InputOutput);
                Instance.DAExecuteNonQuery();

                if(Instance.DASqlCommand.Parameters["@JSON_MAIL_DATA"].Value != null)
                {
                    parametros_mail = Instance.DASqlCommand.Parameters["@JSON_MAIL_DATA"].Value.ToString();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
	}
}
