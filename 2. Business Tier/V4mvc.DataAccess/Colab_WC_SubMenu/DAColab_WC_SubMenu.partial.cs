
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
    public partial class DAColab_WC_SubMenu
    {
        #region [ Consultas ]
        public ObservableCollection<Colab_WC_SubMenu> GetAllColabWCSubMenu_EmpUsuariosCtta(string RUT)
        {
            try
            {
                ObservableCollection<Colab_WC_SubMenu> items = new ObservableCollection<Colab_WC_SubMenu>();
                Colab_WC_SubMenu item = new Colab_WC_SubMenu();
                Instance.DAAsignarProcedure("V4MVC_COLAB_WC_SUBMENU_SELECT_EMPUSUARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Colab_WC_SubMenu();
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
	