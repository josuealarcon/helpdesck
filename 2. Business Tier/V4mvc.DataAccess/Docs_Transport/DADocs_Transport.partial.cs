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

        public Docs_Transport GetDocsTransportDocumentoValidado(string DIVCOD, string PATENTE, int ID_DOC, string COMUN_DIV, int? COMUN, string IDEMPRESA)
        {
            try
            {
                Docs_Transport item = new Docs_Transport();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_SELECT_VALIDADO");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.VarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.VarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN_DIV", COMUN_DIV, SqlDbType.VarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN", COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.VarChar, 11, ParameterDirection.Input);
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

        public ObservableCollection<Docs_Transport> GetDocsHistoricoVehiculosCtta(int ID_DOC, string PATENTE, string DIVCOD)
        {
            try
            {
                ObservableCollection<Docs_Transport> items = new ObservableCollection<Docs_Transport>();
                Docs_Transport item = new Docs_Transport();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_HISTORICOCTTA");
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.VarChar, 4, ParameterDirection.Input);
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

        public Docs_Transport GetDocTransportsDisputa(string ID, string DIVCOD, int ID_DISPUTA)
        {
            try
            {
                Docs_Transport item = new Docs_Transport();

                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_SELECT_DATOS_DISPUTA");
                Instance.DAAgregarParametro("@ID", Guid.Parse(ID), SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);
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


		public bool DocsTransport_Insert_HistoricoVehiculosCtta(Docs_Transport item)
		{
			try 
			{
			    Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_INSERT_HISTORICO_VEHICULULOSCTTA");
                Instance.DAAgregarParametro("@PATENTE", item.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
