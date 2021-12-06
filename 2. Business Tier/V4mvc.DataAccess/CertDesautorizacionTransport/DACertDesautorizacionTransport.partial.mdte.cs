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
	public partial class DACertDesautorizacionTransport
	{
		#region [ Consultas ]

		public CertDesautorizacionTransport GetOneCertDesautorizacion_CertificacionMdte(string PATENTE, string DIVCOD)
        {
            try
            {
                var item = new CertDesautorizacionTransport();
                Instance.DAAsignarProcedure("V4MVC_CERT_DESAUTORIZACION_TRANSPORT_SELECT_ONE_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public bool SaveCertDesautorizacionTransport_CertificacionMdte(ref CertDesautorizacionTransport modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_CERT_DESAUTORIZACION_TRANSPORT_INSERT_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION", modelo.OBSERVACION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BLOQUEA", modelo.BLOQUEA, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", modelo.DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                Instance.DAAgregarParametro("@ID_ARCHIVO", modelo.ID_ARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USRBLOQUEA", modelo.USRBLOQUEA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
