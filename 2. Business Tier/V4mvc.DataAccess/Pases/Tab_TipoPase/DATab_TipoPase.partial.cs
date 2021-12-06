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
	public partial class DATab_TipoPase
	{
		#region [ Consultas ]
		public ObservableCollection<Tab_TipoPase> GetAllTabTipoPase_PasesCtta()
        {
            try
            {
                ObservableCollection<Tab_TipoPase> items = new ObservableCollection<Tab_TipoPase>();
                Tab_TipoPase item = null;
                Instance.DAAsignarProcedure("V4MVC_TAB_TIPOPASE_SELECT_PASES_CTTA");
                
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Tab_TipoPase();
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
