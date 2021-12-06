
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
    public partial class DALinksVideosV4
    {
        #region [ Consultas ]

        public ObservableCollection<LinksVideosV4> GetVideoLinks(string VIEW_KEY)
        {
            try
            {
                ObservableCollection<LinksVideosV4> items = new ObservableCollection<LinksVideosV4>();
                Instance.DAAsignarProcedure("V4MVC_LINKS_VIDEOS_V4_SELECT_VISTALINKS");
                Instance.DAAgregarParametro("@CLAVE_VISTA", VIEW_KEY, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new LinksVideosV4();
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
	