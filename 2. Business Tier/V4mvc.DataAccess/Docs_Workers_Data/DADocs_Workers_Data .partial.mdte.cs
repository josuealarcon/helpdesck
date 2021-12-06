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
	public partial class DADocs_Workers_Data 
	{
        #region [ Consultas ]

        public Docs_Workers_Data GetOneDocsWorkersDataDatos_Mdte(Guid ID_DOC, string EMPRESA)
        {
            try
            {
                var item = new Docs_Workers_Data();
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_DATA_SELECT_DATOS_MDTE");
                Instance.DAAgregarParametro("@ID", ID_DOC, SqlDbType.UniqueIdentifier,200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

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
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
