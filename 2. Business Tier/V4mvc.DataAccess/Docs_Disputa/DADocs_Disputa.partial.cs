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
    public partial class DADocs_Disputa
    {
        #region [ Consultas ]

        public Docs_Disputa GetDocumentacionDisputaCtta(string RUT, string DIVCOD, int ID_DOC, Guid? ID, string COMUN_DIV, string IDEMPRESA)
        {
            try
            {
                Docs_Disputa item = new Docs_Disputa();
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_SELECT_DOCUMENTO_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COMUN_DIV", COMUN_DIV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);

                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        item = new Docs_Disputa();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    {
                        return null;
                    }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs_Disputa> GetInformeDocsPendientesDisputaCtta(ref Docs_Disputa model)
        {
            try
            {
                ObservableCollection<Docs_Disputa> items = new ObservableCollection<Docs_Disputa>();
                Docs_Disputa item = new Docs_Disputa();
                Instance.DAAsignarProcedure("V4MVC_INFORME_DOCS_PENDIENTES_DISPUTA_CTTA");
                Instance.DAAgregarParametro("@FECHAINI", model.FECHAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHAFIN", model.FECHAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Disputa();
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

        #region [ Metodos ]
        public bool SaveDisputa(ref Docs_Disputa item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_DISPUTA_INSERT_DISPUTA");
                Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OBSERVACION", item.OBSERVACION, SqlDbType.NVarChar, 1000, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTUSUARIO", item.CERTUSUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTFECHA", item.CERTFECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CERTHORA", item.CERTHORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ESTADO", item.ESTADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);

                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #endregion
    }
}
