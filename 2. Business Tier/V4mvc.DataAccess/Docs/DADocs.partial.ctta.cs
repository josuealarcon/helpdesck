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
    public partial class DADocs
    {
        #region [ Consultas ]

        public ObservableCollection<Docs> GetAllDocumentacionDocsCtta(string DIVCOD, int? ID_DOC_OPCION, string RUT, string EMPRESA)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_DOCUMENTOS_CTTA");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC_OPCION", ID_DOC_OPCION, SqlDbType.Int, 4, ParameterDirection.Input);
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


        public ObservableCollection<Docs> GetAllDGruposCtta()
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_AGRUPACION_SELECT_GRUPOS_CTTA");
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

        public ObservableCollection<Docs> GetDocumentacionDocsObligatorioCtta(String DIVCOD, int ID_DOC)
        {
            try
            {

                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();

                //using (SqlConnection connection = _dbFactory.EstablishedConnection())
                //{
                //    SqlCommand Instance = new SqlCommand("V4MVC_DOCS_SELECT_OBLIGATORIOS_CTTA", connection);

                //    Instance.CommandType = CommandType.StoredProcedure;

                //    Instance.Parameters.AddWithValue("@ID_DOC", ID_DOC);
                //    Instance.Parameters.AddWithValue("@DIVCOD", DIVCOD);

                //    using (IDataReader reader = Instance.ExecuteReader())
                //    {
                //        if (reader.Read())
                //        {
                //            item = new Docs();
                //            Loader.LoadEntity(reader, item);
                //            item.Instance = InstanceEntity.Unchanged;
                //            items.Add(item);
                //        }
                //        else
                //        { return null; }
                //    }
                //}


                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_OBLIGATORIOS_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetDocumentoDependencias(int ID_DOC, string DIVCOD,string RUT,string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_DEPENDENCIA_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetDivisionesConduccionPase(string RUT, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DIVISIONES_SELECT_CONDUCCIONPASE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetDocsDivision(string DIVCOD)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_DIVISION");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetDocsTipoPaseFecDivision(string DIVCOD)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TIPOPASE_FEC_SELECT_DIVISION");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
        public ObservableCollection<Docs> GetAllDocumentacionVehiculosCtta(string DIVCOD, string PATENTE)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_VEHICULOS_CTTA");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetDocsDependenciasVehiculosCtta(string DIVCOD, string PATENTE, int ID_DOC, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_DEPENDENCIAS_VEHICULOSCTTA");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", PATENTE, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetAllDocumentacionEmpresasCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_EMPRESA_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetAllDocs_ControlLaboralCtta(ref Timeline parametros)
        {

            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", parametros.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLABORAL_MSG_EXISTE", parametros.CLABORAL_MSG_EXISTE, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@VALIDA", parametros.VALIDA, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CARGAR", parametros.CARGAR, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CM_EXISTEN_DOCS", 0, SqlDbType.Int, 8, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CM_NOMBRE", null, SqlDbType.NVarChar, 50, ParameterDirection.Output);
                Instance.DAAgregarParametro("@CM_IDDOC", 0, SqlDbType.Int, 8, ParameterDirection.Output);

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
                if (Instance.DASqlCommand.Parameters["@CLABORAL_MSG_EXISTE"].Value != null)
                {
                    parametros.CLABORAL_MSG_EXISTE = int.Parse(Instance.DASqlCommand.Parameters["@CLABORAL_MSG_EXISTE"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@VALIDA"].Value != null)
                {
                    parametros.VALIDA = int.Parse(Instance.DASqlCommand.Parameters["@VALIDA"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@CARGAR"].Value != null)
                {
                    parametros.CARGAR = int.Parse(Instance.DASqlCommand.Parameters["@CARGAR"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@CM_EXISTEN_DOCS"].Value != null)
                {
                    parametros.CM_EXISTEN_DOCS = int.Parse(Instance.DASqlCommand.Parameters["@CM_EXISTEN_DOCS"].Value.ToString());
                }
                if (Instance.DASqlCommand.Parameters["@CM_NOMBRE"].Value != null)
                {
                    parametros.CM_NOMBRE = Instance.DASqlCommand.Parameters["@CM_NOMBRE"].Value.ToString();
                }
                if (Instance.DASqlCommand.Parameters["@CM_IDDOC"].Value != null)
                {
                    parametros.CM_IDDOC = int.Parse(Instance.DASqlCommand.Parameters["@CM_IDDOC"].Value.ToString());
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDocMixed(int ID_DOC)
        {
            try
            {
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_MIXED_EMPRESA_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public Docs GetOneDoc_v2_ControlLaboralCtta(int ID_TIPO_PROPIETARIO, int ID_DOC_OPCION, int ID_DOC)
        {
            try
            {
                Docs item = new Docs();
                //V4MVC_DOCS_SELECT_CARGAMASIVA_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_ONE_V2_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_TIPO_PROPIETARIO", ID_TIPO_PROPIETARIO, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC_OPCION", ID_DOC_OPCION, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetAllDocs_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
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

        public Docs GetOneDoc_ControlLaboralCtta(int ID_DOC)
        {
            try
            {
                Docs item = new Docs();
                //V4MVC_DOCS_SELECT_CARGAMASIVA_CONTROLLABORAL_CTTA
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_ONE_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
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

        public Docs GetOneDocAprobacion_Subcontrato() {
            try
            {
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_DOCAPROBACION_SUBCONTRATOS");
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

        #endregion

        #region [ Informes ]
        public ObservableCollection<Docs> GetDocs_Grid_FichaVehiculoDetalle_InformeConsultaRapidaCtta(Docs request)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_GRID_FICHAVEHICULODETALLE_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@DIVCOD", request.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", request.PATENTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", request.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetDocs_Grid1_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_GRID1_INFORME_FICHAFUNCIONARIODET_INFORMESFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@DIVCOD", request.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOPASE", request.TIPOPASE, SqlDbType.NVarChar, 9, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", request.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", request.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public ObservableCollection<Docs> GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request)
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_GRID2_INFORME_FICHAFUNCIONARIODET_INFORMESFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@DIVCOD", request.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOPASE", request.TIPOPASE, SqlDbType.NVarChar, 9, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", request.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", request.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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

        public int GetDocsScalarAccesoFaena_InformeFuncionariosCtta(string RUT, string IDEMPRESA, string TIPOPASE, string DIVCOD)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_ONE_GETACCESOFAENA_INFORMEFUNCIONARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_PASE", TIPOPASE, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 12, ParameterDirection.Input);

                return (int)Instance.DAExecuteScalar();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool SaveDocument_EmpresaCtta(ref Docs item, out bool result)
        {
            try
            {
                result = false;

                Instance.DAAsignarProcedure("V4MVC_DOCS_ENTERPRISE_INSERT_EMPRESA_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", item.ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EXTENSION", item.EXTENSIONES, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RET", result, SqlDbType.Bit, 2, ParameterDirection.Output);
                Instance.DAAgregarParametro("@NUEVO_ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Output);

                if (Instance.DAExecuteNonQuery() > 0)
                {
                    if (Instance.DASqlCommand.Parameters["@RET"].Value != null)
                    {
                        result = Boolean.Parse(Instance.DASqlCommand.Parameters["@RET"].Value.ToString());
                    }
                    if (Instance.DASqlCommand.Parameters["@NUEVO_ID"].Value != null)
                    {
                        item.ID = Guid.Parse(Instance.DASqlCommand.Parameters["@NUEVO_ID"].Value.ToString());
                    }
                    return true; 
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeleteDocument_EmpresaCtta(Guid ID, string ID_EMPRESA) {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_ENTERPRISE_DELETE_EMPRESA_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_EMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                
                if (Instance.DAExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ func_getdatos V3 ]

        public Docs GetDocsById_Doc(string ID_DOC)
        {
            try
            {
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT_BY_ID_DOC_CTTA");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.NVarChar, 500, ParameterDirection.Input);
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

        #endregion

    }
}
