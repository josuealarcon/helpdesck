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
	public partial class DADocs_Transport_Rechazo
	{
        #region [ Consultas ]
        public ObservableCollection<Docs_Transport_Rechazo> GetDocsTransportRechazoSelectDisputa(string ID)
        {
            try
            {
                ObservableCollection<Docs_Transport_Rechazo> items = new ObservableCollection<Docs_Transport_Rechazo>();
                Docs_Transport_Rechazo item = new Docs_Transport_Rechazo();
                Instance.DAAsignarProcedure("V4MVC_DOCS_TRANSPORT_RECHAZO_SELECT_DISPUTA");
                Instance.DAAgregarParametro("@ID", Guid.Parse(ID), SqlDbType.UniqueIdentifier, 100, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Transport_Rechazo();
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
