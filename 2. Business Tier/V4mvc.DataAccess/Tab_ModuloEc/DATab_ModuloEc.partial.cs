
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
    public partial class DATab_ModuloEc
    {
        #region [ Consultas ]
        public ObservableCollection<Tab_ModuloEc> GetAllTabModuloEc_EmpUsuariosCtta()
        {
            try
            {
                ObservableCollection<Tab_ModuloEc> items = new ObservableCollection<Tab_ModuloEc>();
                Tab_ModuloEc item = new Tab_ModuloEc();
                Instance.DAAsignarProcedure("V4MVC_TAB_MODULOEC_SELECT_EMPUSUARIOS_CTTA");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Tab_ModuloEc();
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
	