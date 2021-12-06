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
	public partial class DADocs_Workers_Data
	{
        #region [ Consultas ]

        public Docs_Workers_Data GetDocWorkersDataDisputa(string ID)
        {
            try
            {
                Docs_Workers_Data item = new Docs_Workers_Data();

                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_DATA_SELECT_DISPUTA");
                Instance.DAAgregarParametro("@ID",Guid.Parse(ID), SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
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

        #region [ Metodos ]

        #endregion
    }
}
