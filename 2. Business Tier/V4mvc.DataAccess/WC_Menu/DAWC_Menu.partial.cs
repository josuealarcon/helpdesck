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
	public partial class DAWC_Menu
	{
        #region [ Consultas ]

        public ObservableCollection<WC_Menu> GetAllMenuCtta()
        {
            try
            {
                ObservableCollection<WC_Menu> items = new ObservableCollection<WC_Menu>();
                WC_Menu item = new WC_Menu();
                Instance.DAAsignarProcedure("V4MVC_COLAB_WC_MENU_SELECT");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WC_Menu();
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

        public ObservableCollection<WC_Menu> GetAllMenuMdte()
        {
            try
            {
                ObservableCollection<WC_Menu> items = new ObservableCollection<WC_Menu>();
                WC_Menu item = new WC_Menu();
                Instance.DAAsignarProcedure("V4MVC_WCMENU_SELECT");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WC_Menu();
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
