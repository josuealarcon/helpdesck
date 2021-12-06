
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
    public partial class DATimeline
    {
        #region [ Consultas ]
        public ObservableCollection<Timeline> GetAllTimeline_ControlLaboralCtta()
        {
            try
            {
                ObservableCollection<Timeline> items = new ObservableCollection<Timeline>();
                Timeline item = new Timeline();
                Instance.DAAsignarProcedure("V4MVC_TIMELINE_SELECT_CONTROLLABORAL_CTTA");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Timeline();
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
	