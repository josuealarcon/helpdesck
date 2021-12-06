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
    public partial class DADocs_Transport
    {
        #region [ Consultas ]

        public ObservableCollection<Docs_Transport> GetListDocsTransport_Mdte(string PATENTE, int ID_DOC, Guid ID, int ID_DISPUTA)
        {
            try
            {
                ObservableCollection<Docs_Transport> items = new ObservableCollection<Docs_Transport>();
                Docs_Transport item = new Docs_Transport();

                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_SELECT_SENDEMAIL_VEHDISPUTA_MDTE");
                Instance.DAAgregarParametro("@PATENTE",PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Transport();
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
        public ObservableCollection<Docs_Transport> GetListDocTransportsArchivosAlmacenados_Mdte(string PATENTE, string DIVCOD, int ID_DOC, string EMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Transport> items = new ObservableCollection<Docs_Transport>();
                Docs_Transport item = new Docs_Transport();

                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_SELECT_ARCHIVOS_ALMACENADOS_MDTE");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 50, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Transport();
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

        #endregion

        #region [ Metodos ]
        public bool saveDocsTransport_Mdte(ref Docs Docs)
        {
            try
            {
                if (Docs.Instance != InstanceEntity.Unchanged)
                {
                    switch (Docs.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_INSERT_DOCUMENTOS_MDTE");
                            break;  
                    }
                        Instance.DAAgregarParametro("@PATENTE", Docs.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", Docs.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", Docs.ARCHIVO_CARGADO.NOMBRE, SqlDbType.NVarChar,50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPO_CONTENIDO", Docs.ARCHIVO_CARGADO.TIPOCONTENIDO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_DOC", Docs.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIVISION", Docs.DIVISION, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO", Docs.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID", Docs.ID, SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
                    if (Instance.DAExecuteNonQuery() > 0)
                    { return true; }
                    else
                    { return false; }
                }
                else
                { return true; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
