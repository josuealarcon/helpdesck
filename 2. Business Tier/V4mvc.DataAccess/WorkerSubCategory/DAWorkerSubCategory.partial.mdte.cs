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
	public partial class DAWorkerSubCategory
	{
		#region [ Consultas ]

        public ObservableCollection<WorkerSubCategory> GetAllWorkerSubCategory_PasesMdte()
        {
            try
            {
                ObservableCollection<WorkerSubCategory> items = new ObservableCollection<WorkerSubCategory>();
                WorkerSubCategory item = new WorkerSubCategory();
                Instance.DAAsignarProcedure("V4MVC_SUB_CATEGORIACONTRATISTA_SELECT_PASES_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WorkerSubCategory();
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
