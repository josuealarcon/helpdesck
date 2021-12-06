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
	public partial class DADocs_Workers_Rechazo
	{
        #region [ Consultas ]
        public ObservableCollection<Docs_Workers_Rechazo> GetListDocumentosRechazo_mdte(Guid? ID)
        {
            try
            {
                var items = new ObservableCollection<Docs_Workers_Rechazo>();
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_SELECT_TIPO_RECHAZO_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 30, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        Docs_Workers_Rechazo item = new Docs_Workers_Rechazo();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region [ Metodos ]
        public bool DeleteDocsWorkersRechazoLiquidacion_Mdte(Guid? ID)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_DELETE_LIQUIDACION_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 50, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertDocsWorkersRechazoLiquidacion_Mdte(Docs_Tipo_Rechazo model)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_INSERT_LIQUIDACION_MDTE");
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public bool DeleteDocsWorkersRechazoControlAcceso_Mdte(Guid? ID_ARCHIVO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_DELETE_CONTROL_ACCESO_MDTE");
                Instance.DAAgregarParametro("@ID_ARCHIVO", ID_ARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool InsertDocsWorkersRechazoControlAcceso_Mdte(Docs_Tipo_Rechazo model)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_INSERT_CONTROL_ACCESO_MDTE");
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", model.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_ARCHIVO", model.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_TIPO_RECHAZO", model.ID_TIPO_RECHAZO, SqlDbType.Int, 4, ParameterDirection.Input);
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
