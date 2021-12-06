using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DACasino : IDACasino
    {

        #region [ Propiedades ]

        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Casino> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }

        #endregion

        #region [ Constructores ]

        public DACasino(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<Casino>();
            Casino item = new Casino();
            Loader.EntityType = item.GetType();
            Instance = container;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Casino> GetAll()
        {
            try
            {
                ObservableCollection<Casino> items = new ObservableCollection<Casino>();
                Casino item = new Casino();
                Instance.DAAsignarProcedure("V4MVC_CASINOMES_SELECT_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Casino();
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

        public Casino GetOne()
        {
            try
            {
                Casino item = new Casino();
                Instance.DAAsignarProcedure("_SI_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}

