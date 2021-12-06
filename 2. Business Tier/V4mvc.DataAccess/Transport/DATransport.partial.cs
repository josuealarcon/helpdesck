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
                Instance.DAAgregarParametro("@COLUMN", model.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", model.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);

                Instance.DAAgregarParametro("@PATENTE", model.COL0, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", model.COL1, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", model.COL2, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", model.COL3, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANOFAB", model.COL4, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
        public ObservableCollection<Transport> GetAllTransportEnterpriseCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Transport> items = new ObservableCollection<Transport>();
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ENTERPRISE_CTTA2");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> BuscarVehiculos(Int32 iDisplayStart, Int32 iDisplayLength, String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB, String sortCOLUMN, String sortDIRECTION)
        {
            try
            {
                ObservableCollection<Transport> items = new ObservableCollection<Transport>();
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_BUSCADORCTTA");
                Instance.DAAgregarParametro("@IDISPLAYSTART", iDisplayStart, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYLENGTH", iDisplayLength, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_PATENTE", searchPATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MARCA", searchMARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MODELO", searchMODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_TIPO", searchTIPO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_ANOFAB", searchANOFAB, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_COLUMN", sortCOLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_DIRECTION", sortDIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport BuscarVehiculos_NumRegistros(String searchPATENTE, String searchMARCA, String searchMODELO, String searchTIPO, String searchANOFAB)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_COUNT_BUSCADORCTTA");
                Instance.DAAgregarParametro("@SEARCH_PATENTE", searchPATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MARCA", searchMARCA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MODELO", searchMODELO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_TIPO", searchTIPO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_ANOFAB", searchANOFAB, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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

        public Transport GetOneTransport_PasesCtta(string PATENTE, int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ONE_PASES_CTTA");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDPASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_INI", FEC_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FEC_FIN", FEC_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
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

        public ObservableCollection<Transport> GetTransportsAcreditacionVehicularCtta(string IDEMPRESA, string DIVCOD) {
            try
            {
                ObservableCollection<Transport> items = new ObservableCollection<Transport>();
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_ACREDITACIONVEHICULAR_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Transport> GetAllTransportDatatablesCtta(ref JqueryDatatableParam model, out int iTotalCount)
        {
            try
            {
                ObservableCollection<Transport> items = new ObservableCollection<Transport>();
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_DATATABLES_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", model.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYSTART", model.iDisplayStart, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDISPLAYLENGTH", model.iDisplayLength, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_PATENTE", model.sSearch_0, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MARCA", model.sSearch_1, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MODELO", model.sSearch_2, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_COLUMN", model.iSortCol_0, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SORT_DIRECTION", model.sSortDir_0, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TOTAL_COUNT", 0, SqlDbType.NVarChar, 4, ParameterDirection.InputOutput);
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
                iTotalCount = 0;
                if (Instance.DASqlCommand.Parameters["@TOTAL_COUNT"].Value != null)
                {
                    iTotalCount = int.Parse(Instance.DASqlCommand.Parameters["@TOTAL_COUNT"].Value.ToString());
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Transport GetAllTransportDatatablesCountCtta(ref JqueryDatatableParam model)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_DATATABLES_COUNT_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", model.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_PATENTE", model.sSearch_0, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MARCA", model.sSearch_1, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@SEARCH_MODELO", model.sSearch_2, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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

        public int GetTransportCumpleCertificacion_Ctta(string PATENTE, int? TIPO,string DIVCOD)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_CERTIFICACION_CTTA");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", TIPO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Transport GetDataByPatente_VehiculosCtta(string patente)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_VER_PATENTE_VEHICULOS_CTTA");
                Instance.DAAgregarParametro("@PATENTE", patente, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        #endregion

        #region [ Informes ]
        public Transport GetTransport_DatosFichaVehiculo_InformeConsultaRapidaCtta(Transport request)
        {
            try
            {
                Transport item = new Transport();
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_DATOS_FICHAVEHICULO_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@PATENTE", request.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
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

        public Transport GetTransport_ValidaExistenciaPatente_InformeConsultaRapidaCtta(Transport Item)
        {
            try
            {
                bool EXISTE = false;
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_VALIDA_EXISTENCIA_PATENTE_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@PATENTE", Item.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXISTE", false, SqlDbType.Bit, 1, ParameterDirection.Output);                
                Instance.DAExecuteNonQuery();

                if (Instance.DASqlCommand.Parameters["@EXISTE"].Value != null)
                {
                    EXISTE = Boolean.Parse(Instance.DASqlCommand.Parameters["@EXISTE"].Value.ToString());
                }              
                return new Transport() { EXISTE = EXISTE };
            }
            catch (Exception ex)
            { throw ex; }
        }

        public DataSet GetAllTransport_IAcreditacionVeh_Informes(ref Transport parametros)
        {
            DataSet ret_ds = null;
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_SELECT_IACREDVEHICULAR_INFORMES_CTTA");

                Instance.DAAgregarParametro("@DIVISION", parametros.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", parametros.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO_DESDE", parametros.PERIODO_DESDE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", parametros.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_VEH", parametros.TIPOVEHICULO, SqlDbType.NVarChar, 20, ParameterDirection.Input);

                Instance.DAAgregarParametro("@COLUMNAS", "", SqlDbType.NVarChar, 4000, ParameterDirection.Output);
                Instance.DAAgregarParametro("@REQUISITOS", "", SqlDbType.NVarChar, 4000, ParameterDirection.Output);

                ret_ds = Instance.DAExecuteDataSet();

                if (Instance.DASqlCommand.Parameters["@COLUMNAS"].Value != null)
                    parametros.COLUMNAS = Instance.DASqlCommand.Parameters["@COLUMNAS"].Value.ToString();
                if (Instance.DASqlCommand.Parameters["@REQUISITOS"].Value != null)
                    parametros.REQUISITOS = Instance.DASqlCommand.Parameters["@REQUISITOS"].Value.ToString();

                return ret_ds;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        public bool DeleteTransportCtta(string PATENTE, string IDEMPRESA)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_DELETE_CTTA");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransport_VehiculosCtta(ref Transport vehiculo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_UPDATE_VEHICULOS_CTTA");
                Instance.DAAgregarParametro("@PATENTE", vehiculo.PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", vehiculo.MARCA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", vehiculo.MODELO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLOR", vehiculo.COLOR, SqlDbType.NVarChar, 60, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", vehiculo.TIPO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANOFAB", vehiculo.ANOFAB, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FUNCACARGO", vehiculo.FUNCACARGO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@KILOMETRAJE", vehiculo.KILOMETRAJE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NUMINT", vehiculo.NUMINT, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDCOMBUSTIBLE", vehiculo.IDCOMBUSTIBLE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDTRACCION", vehiculo.IDTRACCION, SqlDbType.Int, 4, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool UpdateAreasAsignadas_VehiculosCtta(string area, string patente)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_UPDATE_AREAS_ASIGNADAS_VEHICULOS_CTTA");
                Instance.DAAgregarParametro("@PATENTE", patente, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@AREA", area, SqlDbType.NVarChar, 120, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool SaveTransport_VehiculosCtta(Transport vehiculo)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_INSERT_VEHICULOS_CTTA");
                Instance.DAAgregarParametro("@PATENTE", vehiculo.PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MARCA", vehiculo.MARCA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MODELO", vehiculo.MODELO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLOR", vehiculo.COLOR, SqlDbType.NVarChar, 60, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO", vehiculo.TIPO, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ANOFAB", vehiculo.ANOFAB, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FUNCACARGO", vehiculo.FUNCACARGO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@KILOMETRAJE", vehiculo.KILOMETRAJE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NUMINT", vehiculo.NUMINT, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDCOMBUSTIBLE", vehiculo.IDCOMBUSTIBLE, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDTRACCION", vehiculo.IDTRACCION, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", vehiculo.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool UpdateTransportEnterpriseCtta(string PATENTE, string EMPRESA)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_TRANSPORT_UPDATE_ENTERPRISE_CTTA");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

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
