using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Microsoft.Practices.EnterpriseLibrary.Data;

using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.DataAccess
{
    public partial class DADocs
    {
        #region [ Consultas ]

       

        public ObservableCollection<Docs> GetExistencia_DOCS_Mdte()
        {
            try
            {

                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_MDTE");              
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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

        public ObservableCollection<Docs> GetAllAcredFuncionarioDocs_Mdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_MODAL_ACREDITACION_FUNCIONARIO_MDTE");
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOPASE", modelo.TIPOPASE, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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

        public ObservableCollection<Docs> GetAllDocsAcredFuncionarioConduccion_Mdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_CONDUCCION_MODAL_ACREDITACION_FUNCIONARIO_MDTE");
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOPASE", modelo.TIPOPASE, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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

        public ObservableCollection<Docs> GetAllDocsAcredVehiculo_Mdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_MODAL_ACREDITACION_VEHICULO_MDTE");
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOPASE", modelo.TIPOPASE, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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

        public ObservableCollection<Docs> GetAllDocs_CertificacionMdte(string PATENTE, string DIVCOD, string TIPO_VEHICULO)
        {
            try
            {

                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_VEHICULO", TIPO_VEHICULO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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

        public ObservableCollection<Docs> GetAllDocs_CertificacionDocsMdte(ref Docs modelo)
        {
            try
            {

                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_DOCS_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_VEHICULO", modelo.TIPO_VEHICULO, SqlDbType.NVarChar, 9, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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

        public Docs GetOneDocsNombreArchivo_Mdte(int ID_DOC , string PATENTE , string EMPRESA, string DIVCOD)
        {
            try 
            {
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_NOMBREDOCS_MDTE");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE",PATENTE , SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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


        public ObservableCollection<Docs> GetAllCertificadosPases_Mdte(string RUT, string DIVCOD, int NRO, int OPCION)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_CERTIFICADOS_FUNCIONARIOS_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NRO", NRO, SqlDbType.Int, 4, ParameterDirection.Input);              
                Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OPCION", OPCION, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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
        public ObservableCollection<Docs> GetListDocumentos_Mdte()
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_DOCUMENTOS_CONTRATISTAS_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs();
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



    }
}
