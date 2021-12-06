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

        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionValidadaChecked_Mdte(Guid? ID, string RUT) {
            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPO_RECHAZO_SELECT_RECHAZAR_DOCUMENTO_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);

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
            {

                throw ex;
            }
        
        }
      
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoVehiculosChecked_Mdte(Guid ID, int ID_DOC, string PATENTE)
        {
            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_RECHAZO_SELECT_CHECKED_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 20, ParameterDirection.Input);

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

        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoChecked_Mdte(Guid ID, int ID_DOC, string RUT)
        {
            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPO_RECHAZO_SELECT_CHECKED_MDTE");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);

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
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoLiquidacionChecked_Mdte(Guid? ID)
        {

            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPO_RECHAZO_SELECT_CHECKED_LIQUIDACION_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);

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
        public ObservableCollection<Docs_Tipo_Rechazo> GetListDocsTipoRechazoControlAccesoChecked_Mdte(Guid ID, int ID_DOC)
        {

            try
            {
                ObservableCollection<Docs_Tipo_Rechazo> items = new ObservableCollection<Docs_Tipo_Rechazo>();
                Docs_Tipo_Rechazo item = new Docs_Tipo_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPO_RECHAZO_SELECT_CHECKED_CONTROL_ACCESO_DISPUTA_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);

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
        public bool DeleteDocsWorkersRechazoFuncionario_Mdte(Guid ID)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_DELETE_FUNCIONARIO_MDTE");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool InsertDocsWorkersRechazoFuncionario_Mdte(Docs_Tipo_Rechazo model)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_INSERT_FUNCIONARIO_MDTE");
                Instance.DAAgregarParametro("@ID", model.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", model.ID_DOC, SqlDbType.Int, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", model.USUARIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
