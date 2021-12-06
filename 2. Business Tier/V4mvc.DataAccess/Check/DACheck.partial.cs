using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DACheck
    {
        #region [ Consultas ]
        public ObservableCollection<Check> Get_Check_Combo(Check Item)
        {
            try
            {
                ObservableCollection<Check> items = new ObservableCollection<Check>();
                Check item = new Check();
                Instance.DAAsignarProcedure("V4MVC_CHECK_SELECT_COMBO");
                Instance.DAAgregarParametro("@ID_TIPO", Item.ID_TIPO, SqlDbType.NVarChar, 3, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Check();
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