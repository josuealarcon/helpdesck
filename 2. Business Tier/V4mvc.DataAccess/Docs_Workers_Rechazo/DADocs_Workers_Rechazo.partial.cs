using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DADocs_Workers_Rechazo
	{
        #region [ Consultas ]
        public ObservableCollection<Docs_Workers_Rechazo> GetAllMotivosRechazo(Guid ID, string DIVISION)
        {
            try
            {
                ObservableCollection<Docs_Workers_Rechazo> items = new ObservableCollection<Docs_Workers_Rechazo>();
                Docs_Workers_Rechazo item = new Docs_Workers_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_WORKERS_RECHAZO_SELECT_MOTIVOS_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Workers_Rechazo();
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
