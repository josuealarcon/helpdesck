
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DADocs_OST2
    {
        #region [ Consultas ]

        public ObservableCollection<Docs_OST2> GetInformeContratosCArranqueDocsOst2Ctta(ref Docs_OST2 model)
        {
            try
            {
                ObservableCollection<Docs_OST2> items = new ObservableCollection<Docs_OST2>();
                Docs_OST2 item = new Docs_OST2();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CONTRATOSCARRANQUE_DOCS_OST2_CTTA");
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", model.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", model.NIVEL, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_OST2();
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
        public bool InsertDocsOST2_ContratOSTCtta(Guid ID_ARCHIVO, int ID_DOC, string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOCS_OST2_INSERT_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@ID_ARCHIVO", ID_ARCHIVO, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);

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
    }
}
	