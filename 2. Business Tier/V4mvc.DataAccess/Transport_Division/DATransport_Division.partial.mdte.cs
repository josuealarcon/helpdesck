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
    public partial class DATransport_Division
    {
        #region [ Consultas ]

        public Transport_Division GetOneTransportDivision_CertificacionMdte(string DIVCOD, string PATENTE)
        {
            try
            {
                var item = new Transport_Division();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_DIVISION_SELECT_ONE_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        #region [ Metodos ]


        #endregion
    }
}
