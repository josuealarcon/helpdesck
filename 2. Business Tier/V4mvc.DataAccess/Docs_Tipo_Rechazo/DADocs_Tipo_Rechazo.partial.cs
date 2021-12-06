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
	public partial class DADocs_Tipo_Rechazo
	{
        #region [ Consultas ]

        public ObservableCollection<Docs_Tipo_Rechazo> GetDocsTipoRechazoDisputa(string DIVCOD, string COMUN_DIV,string ID)
        {
            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPO_RECHAZO_SELECT_DISPUTA");
                Instance.DAAgregarParametro("@ID", Guid.Parse(ID), SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN_DIV", COMUN_DIV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Tipo_Rechazo();
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

        public ObservableCollection<Docs_Tipo_Rechazo> GetDocsTipoRechazoDisputaFuncionariosCtta(string FECHA_INI, string FECHA_FIN, string RUT, Guid ID_ARCHIVO)
        {
            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPO_RECHAZO_SELECT_DISPUTA_FUNCIONARIOSCCTA");
                Instance.DAAgregarParametro("@FECHA_INI", FECHA_INI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_FIN", FECHA_FIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_ARCHIVO", ID_ARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Tipo_Rechazo();
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

        public ObservableCollection<Docs_Tipo_Rechazo> GetDocsTipoRechazoLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_GETDOCS_TIPO_RECHAZO_LIQUIDACION_FUNCIONARIOSCTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Tipo_Rechazo();
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

        #endregion
    }
}
