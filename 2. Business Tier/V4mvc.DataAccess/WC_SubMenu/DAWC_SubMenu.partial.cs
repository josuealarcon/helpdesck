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
    public partial class DAWC_SubMenu
    {
        #region [ Consultas ]

        public ObservableCollection<WC_SubMenu> GetAllSubMenuCtta(String TIPOUSUARIO)
        {
            try
            {
                ObservableCollection<WC_SubMenu> items = new ObservableCollection<WC_SubMenu>();
                WC_SubMenu item = new WC_SubMenu();
                Instance.DAAsignarProcedure("V4MVC_COLAB_WC_SUBMENU_SELECT_MENU");
                Instance.DAAgregarParametro("@TIPOUSUARIO", TIPOUSUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WC_SubMenu();
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
        public ObservableCollection<WC_SubMenu> GetAllSubMenuMdte(String ADMTIPO, String ADMLUGAR)
        {
            try
            {
                ObservableCollection<WC_SubMenu> items = new ObservableCollection<WC_SubMenu>();
                WC_SubMenu item = new WC_SubMenu();
                Instance.DAAsignarProcedure("V4MVC_WC_SUBMENU_SELECT_MENU");
                Instance.DAAgregarParametro("@ADMTIPO", ADMTIPO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ADMLUGAR", ADMLUGAR, SqlDbType.NVarChar, 15, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WC_SubMenu();
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
