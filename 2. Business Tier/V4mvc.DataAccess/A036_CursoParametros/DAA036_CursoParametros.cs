using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAA036_CursoParametros : IDAA036_CursoParametros
    {

        #region [ Propiedades ]

        public IUnityContainer containerService { get; set; }
        public LoaderEntity<A036_CursoParametros> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }

        #endregion

        #region [ Constructores ]

        public DAA036_CursoParametros(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<A036_CursoParametros>();
            A036_CursoParametros item = new A036_CursoParametros();
            Loader.EntityType = item.GetType();
            Instance = container;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<A036_CursoParametros> GetAll()
        {
            try
            {
                ObservableCollection<A036_CursoParametros> items = new ObservableCollection<A036_CursoParametros>();
                A036_CursoParametros item = new A036_CursoParametros();
                Instance.DAAsignarProcedure("_SI_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new A036_CursoParametros();
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

        public A036_CursoParametros GetOne()
        {
            try
            {
                A036_CursoParametros item = new A036_CursoParametros();
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

