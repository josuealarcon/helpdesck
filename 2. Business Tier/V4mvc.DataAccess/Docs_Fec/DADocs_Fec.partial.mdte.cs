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
    public partial class DADocs_Fec
    {

        #region [ Consultas ]

        public ObservableCollection<Docs_Fec> GetDocumentacionFechasDocumentoMdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_FECHASDOC_MDTE");
                Instance.DAAgregarParametro("@RUT", modelo.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", modelo.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOPASE", modelo.TIPOPASE, SqlDbType.NVarChar, 30, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Fec();
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

        public ObservableCollection<Docs_Fec> GetDocumentacionFechasDocumentoVehiculosMdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_FECHASDOC_V2_MDTE");
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", modelo.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Fec();
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

        public ObservableCollection<Docs_Fec> GetAllDocsFec_CertificacionDocsMdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_FECHASDOC_CERTIFICACION_MDTE");
                Instance.DAAgregarParametro("@PATENTE", modelo.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", modelo.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", modelo.DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", modelo.IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Fec();
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

        public ObservableCollection<Docs_Fec> GetListDocsFecFechaNombre_Mdte(int ID_DOC, string PATENTE, string EMPRESA, string DIVCOD)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_FECHA_NOMBRE_MDTE");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Fec();
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

        public ObservableCollection<Docs_Fec> GetListFechasDocumentos_Mdte()
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_FECHASDOCUMENTOS_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Fec();
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


        public ObservableCollection<Docs_Fec> GetCertificadosPasesFechas_Mdte(string RUT,string DIV_COD, int ID_DOC)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_FECHAS_FUNCIONARIOS_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIV_COD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Fec();
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
        


        public ObservableCollection<Docs_Fec> GetAllDocsFecSelect_mdte()
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_DOCSFECHAS_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Fec();
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
