using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Microsoft.Practices.EnterpriseLibrary.Data;

using V4mvc.Entities;


namespace V4mvc.DataAccess
{
    public partial class DADocs_Workers
    {

        #region [ Consultas ]

        public ObservableCollection<Docs_Workers> GetDocumentacionEstadoDocCtta(string RUT, String DIVCOD, int ID_DOC, int? COMUN, string COMUN_DIV, string EMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
                Docs_Workers item = new Docs_Workers();

                //using (SqlConnection connection = _dbFactory.EstablishedConnection())
                //{
                //    SqlCommand Instance = new SqlCommand("V4MVC_DOCS_WORKERS_SELECT_ESTADODOC_CTTA", connection);

                //    Instance.CommandType = CommandType.StoredProcedure;

                //    Instance.Parameters.AddWithValue("@RUT", RUT);
                //    Instance.Parameters.AddWithValue("@ID_DOC", ID_DOC);
                //    Instance.Parameters.AddWithValue("@DIVISION", DIVCOD);
                //    Instance.Parameters.AddWithValue("@COMUN", COMUN);
                //    Instance.Parameters.AddWithValue("@COMUN_DIV", COMUN_DIV);
                //    Instance.Parameters.AddWithValue("@EMPRESA", EMPRESA);

                //    using (IDataReader reader = Instance.ExecuteReader())
                //    {
                //        if (reader.Read())
                //        {
                //            item = new Docs_Workers();
                //            Loader.LoadEntity(reader, item);
                //            item.Instance = InstanceEntity.Unchanged;
                //            items.Add(item);
                //        }
                //        else
                //        { return null; }
                //    }
                //}
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_ESTADODOC_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN", COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN_DIV", COMUN_DIV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Workers();
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

        //public ObservableCollection<Docs_Workers> GetDocumentoDependenciaValidado(string RUT, int ID_DOC, string DIVCOD, string COMUN_DIV, int? COMUN, string IDEMPRESA)
        //{
        //    try
        //    {
        //        ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
        //        Docs_Workers item = new Docs_Workers();
        //        Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_DEPENDENCIA_VALIDADO_CTTA");
        //        Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
        //        Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
        //        Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
        //        Instance.DAAgregarParametro("@COMUN", COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
        //        Instance.DAAgregarParametro("@COMUN_DIV", COMUN_DIV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
        //        Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
        //        using (IDataReader reader = Instance.DAExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                item = new Docs_Workers();
        //                Loader.LoadEntity(reader, item);
        //                item.Instance = InstanceEntity.Unchanged;
        //                items.Add(item);
        //            }
        //        }
        //        return items;
        //    }
        //    catch (Exception ex)
        //    { throw ex; }
        //}

        public ObservableCollection<Docs_Workers> GetDocWorkersDocumentosHistorico(string RUT, int ID_DOC, string DIVCOD, string COMUN_DIV, int? COMUN, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
                Docs_Workers item = new Docs_Workers();

                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_HISTORICO_DOCUMENTOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN", COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN_DIV", COMUN_DIV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Workers();
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

        public Docs_Workers GetDocWorkersDisputa(string ID, string DIVCOD, int ID_DISPUTA)
        {
            try
            {
                Docs_Workers item = new Docs_Workers();

                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_DATOS_DISPUTA");
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

        public ObservableCollection<Docs_Workers> GetDocWorkersByRut_FuncionariosCtta(string RUT, string EMPRESA){
            ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
            try
            {
 
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_FUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        Docs_Workers item = new Docs_Workers();
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
        public ObservableCollection<Docs_Workers> GetDocWorkersByRut_FuncionariosCtta(string RUT, string DIVISION, string EMPRESA)
        {
            ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
            try
            {

                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_FUNCIONARIOS_HISTORICO_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        Docs_Workers item = new Docs_Workers();
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
        public ObservableCollection<Docs_Workers> GetInformeDocsPendientesFuncionariosCtta(ref Docs_Workers model)
        {
            try
            {
                ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
                Docs_Workers item = new Docs_Workers();
                Instance.DAAsignarProcedure("V4MVC_INFORME_DOCS_PENDIENTES_FUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Workers();
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

        public bool SaveDocsWorkersDocumento(ref Docs_Workers item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_INSERT_DOCUMENTO");

                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA_MOD", item.FECHA_MOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORA_MOD", item.HORA_MOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHASUBE", item.FECHASUBE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORASUBE", item.HORASUBE, SqlDbType.NVarChar, 8, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDocWorkersDefaults_FuncionariosCtta(ref Docs_Workers item)
        {
            try
            {

                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_INSERT_FUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", 18, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeleteFiniqDocWorker_FuncionariosCtta(string DEL_DOC_ID, string RUT, string USUARIO, string EMPRESA , string DIVCOD)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_DELETE_FUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@DEL_ID_DOCW", Guid.Parse(DEL_DOC_ID), SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);                
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);

                Instance.DAExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ func_getdatos V3 ]

        public ObservableCollection<Docs_Workers> GetDocsWorkersByIdDocCtta(string RUT, string CAMPO_COMUNDIV, string DIVISION, int? ID_DOC, string DIV_COMUN, int? EMP_COMUN, string EMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Workers> items = new ObservableCollection<Docs_Workers>();
                Docs_Workers item = new Docs_Workers();
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_SELECT_ESTADODOC_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CAMPO_COMUNDIV", CAMPO_COMUNDIV, SqlDbType.NVarChar, 500, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIV_COMUN", DIV_COMUN, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMP_COMUN", EMP_COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Workers();
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

    }
}
