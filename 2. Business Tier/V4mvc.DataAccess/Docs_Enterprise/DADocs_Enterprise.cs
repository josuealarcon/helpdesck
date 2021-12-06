using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DADocs_Enterprise : IDADocs_Enterprise
    {

        #region [ Propiedades ]

        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Docs_Enterprise> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }

        #endregion

        #region [ Constructores ]

        public DADocs_Enterprise(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<Docs_Enterprise>();
            Docs_Enterprise item = new Docs_Enterprise();
            Loader.EntityType = item.GetType();
            Instance = container;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Docs_Enterprise> GetAll()
        {
            try
            {
                ObservableCollection<Docs_Enterprise> items = new ObservableCollection<Docs_Enterprise>();
                Docs_Enterprise item = new Docs_Enterprise();
                Instance.DAAsignarProcedure("_SI_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Docs_Enterprise();
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

        public Docs_Enterprise GetOne()
        {
            try
            {
                Docs_Enterprise item = new Docs_Enterprise();
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