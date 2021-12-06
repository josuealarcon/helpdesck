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
	public partial class DAWorkerCategory
	{
		#region [ Consultas ]

        public ObservableCollection<WorkerCategory> GetAllWorkerCategory_PasesCtta()
        {
            try
            {
                ObservableCollection<WorkerCategory> items = new ObservableCollection<WorkerCategory>();
                WorkerCategory item = new WorkerCategory();
                Instance.DAAsignarProcedure("V4MVC_CATEGORIACONTRATISTA_SELECT_PASES_CTTA");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WorkerCategory();
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
