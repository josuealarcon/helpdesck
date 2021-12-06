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
	public partial class DADocs_Disputa_Trans
	{
        #region [ Consultas ]
        #endregion

        #region [ Metodos ]
        public bool SaveDocDisputaTransVehiculo(Docs_Disputa item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_TRANS_INSERT_UPDATE_VEHICULO_MDTE");
                Instance.DAAgregarParametro("@PATENTE", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION_REVAL", item.OBSERVACION , SqlDbType.NVarChar, 2000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", item.ID_DISPUTA, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
