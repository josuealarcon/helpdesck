
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
    public partial class DALogDocsOST2
    {
        #region [ Consultas ]
        public ObservableCollection<LogDocsOST2> GetAllLogDocsOST2_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL, int ID_DOC)
        {
            try
            {
                ObservableCollection<LogDocsOST2> items = new ObservableCollection<LogDocsOST2>();
                LogDocsOST2 item = new LogDocsOST2();
                Instance.DAAsignarProcedure("V4MVC_LOG_DOCS_OST2_SELECT_CONTRATOST_CTTA");
                Instance.DAAgregarParametro("@NROOST", NROOST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LogDocsOST2();
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

        public ObservableCollection<LogDocsOST2> GetInformeContratosCArranqueHistorialCtta(ref LogDocsOST2 model)
        {
            try
            {
                ObservableCollection<LogDocsOST2> items = new ObservableCollection<LogDocsOST2>();
                LogDocsOST2 item = new LogDocsOST2();
                Instance.DAAsignarProcedure("V4MVC_INFORME_CONTRATOSCARRANQUE_HISTORIAL_CTTA");
                Instance.DAAgregarParametro("@OST", model.OST, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@MADRE", model.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NIVEL", model.NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DOC", model.ID_DOC, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LogDocsOST2();
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
	