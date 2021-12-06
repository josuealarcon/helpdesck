using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DATransport
    {

        #region [ Consultas ]

        public ObservableCollection<Transport> GetTransportsSearcherMdte(ref Transport model)
        {
            try
            {
                ObservableCollection<Transport> items = new ObservableCollection<Transport>();
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SEARCHER_MDTE");
                Instance.DAAgregarParametro("@START", model.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", model.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", model.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", model.MARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", model.MODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", model.DSCTIPOV, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANOFAB", model.ANOFAB, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Transport();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                model.COUNT = items.Count > 0 ? items[0].COUNT : 0;
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransport_PasesMdte(Docs modelo)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ONE_PASES_MDTE");
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_VEH", modelo.TIPO_VEHICULO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { throw new Exception("No se encontro el registro."); }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransportExtra_PasesMdte(Transport modelo)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ONE_EXTRA_PASES_MDTE");
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public Transport GetOneTransport_v2_CertificacionMdte(string PATENTE)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ONE_V2_CERTIFICACION_MDTE");
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

        public ObservableCollection<Transport> GetListTransports_Mdte(ref Transport transports)
        {
            try
            {
                var items = new ObservableCollection<Transport>();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_LISTADO_DATOS_MDTE");
                Instance.DAAgregarParametro("@START", transports.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", transports.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", transports.COL0, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", transports.COL1, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", transports.COL2, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO", transports.COL3, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", transports.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", transports.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        transports = new Transport();
                        Loader.LoadEntity(reader, transports);
                        transports.Instance = InstanceEntity.Unchanged;
                        items.Add(transports);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetOneTransport_Acreditacion_CertificacionMdte(string DIVCOD, string PATENTE, string TIPO_VEHICULO, string IDEMPRESA)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ONE_V3_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 15, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_VEHICULO", TIPO_VEHICULO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
		
		public Transport GetOneTransport_Mdte(string PATENTE, string DIVCOD)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_MDTE");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
		
        public Transport GetOneTransport_CertificacionMdte(string PATENTE)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ONE_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        return null; 
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Transport GetOneTransportCertificacion_Mdte(string DIVCOD, string PATENTE, string TIPO_VEHICULO, string IDEMPRESA)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("[V4MVC_TRANSPORT_SELECT_CUMPLECERTIFICACION_MDTE]");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 15, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_VEHICULO", TIPO_VEHICULO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return item; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool ValidarTransportRFID_Mdte(string RFID, string PATENTE)
        {
            try
            {
                Instance.DAAsignarProcedure("[V4MVC_TRANSPORT_VALIDARRFID_MDTE]");
                Instance.DAAgregarParametro("@RFID", RFID, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() == 0 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }
		
        public bool DeleteTransport_Mdte(string PATENTE, int TIPO, string IDEMPRESA, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_DELETE_CTTA");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", TIPO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransport_Mdte(ref Transport Transport)
        {
            try 
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_UPDATE_VEHICULOS_MDTE");
                Instance.DAAgregarParametro("@RUT_PROPIETARIO", Transport.RUT_PROPIETARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANOFAB", Transport.ANOFAB, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", Transport.MODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", Transport.MARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", Transport.TIPO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLOR", Transport.COLOR, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PROPIETARIO", Transport.TIPO_PROPIETARIO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", Transport.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOM_DUENO", Transport.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDO_DUENO", Transport.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO_DUENO", Transport.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RFID", Transport.RFID, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveTransport_Mdte(ref Transport Transport)
        {
            try
            {
                if (Transport.Instance == InstanceEntity.New)
                {
                    Instance.DAAsignarProcedure("V4MVC_TRANSPORT_INSERT_VEHICULOS_MDTE");
                    Instance.DAAgregarParametro("@EMPRESA", Transport.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                }
                else
                {
                    Instance.DAAsignarProcedure("V4MVC_TRANSPORT_UPDATE_VEHICULOS_MDTE");
                }
                Instance.DAAgregarParametro("@PATENTE", Transport.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", Transport.TIPO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLOR", Transport.COLOR, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANOFAB", Transport.ANOFAB, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", Transport.MARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", Transport.MODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PROPIETARIO", Transport.TIPO_PROPIETARIO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT_PROPIETARIO", Transport.RUT_PROPIETARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RFID", Transport.RFID, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACRONIMO_DUENO", Transport.ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOM_DUENO", Transport.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDO_DUENO", Transport.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveTransport_CertificacionMdte(ref Transport modelo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_UPSERT_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", modelo.TIPO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", modelo.EMPRESA, SqlDbType.Int, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT_PROPIETARIO", modelo.RUT_PROPIETARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PROPIETARIO", modelo.TIPO_PROPIETARIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANOFAB", modelo.ANOFAB, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", modelo.MARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIENEWISE", modelo.TIENEWISE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TURNO", modelo.TURNO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", modelo.MODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLOR", modelo.COLOR, SqlDbType.NVarChar, 30, ParameterDirection.Input);

                Instance.DAAgregarParametro("@EQUIPOADAS", modelo.EQUIPOADAS, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RFID", modelo.RFID, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FUNC_PROPIETARIO_NOMBRES", modelo.FUNC_PROPIETARIO_NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FUNC_PROPIETARIO_APELLIDOS", modelo.FUNC_PROPIETARIO_APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMP_PROPIETARIO_ACRONIMO", modelo.EMP_PROPIETARIO_ACRONIMO, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                Instance.DAAgregarParametro("@USUARIO", modelo.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

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
