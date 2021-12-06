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
        public ObservableCollection<Docs_Fec> GetFechasFiniquito_FuncionariosCtta(string RUT, string EMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_FUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        public ObservableCollection<Docs_Fec> GetDocumentacionFechasDocumentoCtta(int ID_DOC, string DIVCOD, string RUT, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();

                //using (SqlConnection connection = _dbFactory.EstablishedConnection())
                //{
                //    SqlCommand Instance = new SqlCommand("V4MVC_DOCS_FEC_SELECT_FECHASDOC_CTTA", connection);

                //    Instance.CommandType = CommandType.StoredProcedure;

                //    Instance.Parameters.AddWithValue("@ID_DOC", ID_DOC);
                //    Instance.Parameters.AddWithValue("@DIVCOD", DIVCOD);

                //    using (IDataReader reader = Instance.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            item = new Docs_Fec();
                //            Loader.LoadEntity(reader, item);
                //            item.Instance = InstanceEntity.Unchanged;
                //            items.Add(item);
                //        }
                //    }
                //}
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_FECHASDOC_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);

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

        public ObservableCollection<Docs_Fec> GetDocsFecVehiculosCtta(int ID_DOC, string DIVCOD, string PATENTE, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();

                Instance.DAAsignarProcedure("V4MVC_DOC_FEC_VEHICULOS_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);

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

        public ObservableCollection<Docs_Fec> GetAllFechasDocsEmpresasCtta(string IDEMPRESA, int ID_DOC)
        {
            try
            {
                ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
                Docs_Fec item = new Docs_Fec();
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_EMPRESA_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        public Nullable<DateTime> GetNowAsDateTime()
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_SELECT_ONE_GETNOWFROMDB_UTILS");
                string resultado = Instance.DAExecuteScalar().ToString();
                return DateTime.ParseExact(resultado, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
