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
	public partial class DADocs_Transport_Rechazo
	{
        #region [ Consultas ]
          #endregion

        #region [ Metodos ]
        public bool DeleteDocsTransportRechazoVehiculo_Mdte(Guid ID)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_RECHAZO_DELETE_VEHICULO_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool InsertDocsTransportRechazoVehiculo_Mdte(Docs_Tipo_Rechazo model)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_RECHAZO_INSERT_VEHICULO_MDTE");
                Instance.DAAgregarParametro("@PATENTE", model.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", model.ID_DOC, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", model.ID, SqlDbType.UniqueIdentifier, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_TIPO_RECHAZO", model.ID_TIPO_RECHAZO, SqlDbType.Int, 6, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion
    }
}
