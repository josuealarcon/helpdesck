using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAInstalacionFaena
    {

        #region [ Consultas ]

        public ObservableCollection<InstalacionFaena> GetAllInstalacionFaena_Mdte()
        {
            try
            {
                ObservableCollection<InstalacionFaena> items = new ObservableCollection<InstalacionFaena>();
                InstalacionFaena item = new InstalacionFaena();
                Instance.DAAsignarProcedure("V4MVC_INSTALACION_FAENA_SELECT_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new InstalacionFaena();
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

    }
}
