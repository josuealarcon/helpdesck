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

        public Transport_Division GetTransport_DivisionAutorizada(string DIVCOD, string PATENTE)
        {
            try
            {
                Transport_Division item = new Transport_Division();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_DIVISION_SELECT_AUTORIZADO");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 6, ParameterDirection.Input);
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
        public int VerificarVehiculoCtta(string PATENTE, string DIVCOD)
        {
            try
            {
                 
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_DIVISION_VERIFICAR_VEHICULO_CTTA");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool ActivarPaseVehiculoCtta(string DIVCOD, string PATENTE, string IDEMPRESA)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_DIVISION_ACTIVAVEHICULO_CTTA"); 
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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
