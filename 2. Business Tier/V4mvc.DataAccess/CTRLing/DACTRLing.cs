using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DACTRLing : IDACTRLing
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<CTRLing> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DACTRLing(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<CTRLing>();
            CTRLing item = new CTRLing();
            Loader.EntityType = item.GetType();
            Instance = container;
        }
        #endregion

        #region [ Consultas ]

        public ObservableCollection<CTRLing> GetAll(string DIVISIONES)
        {
            try
            {
                ObservableCollection<CTRLing> items = new ObservableCollection<CTRLing>();
                CTRLing item = new CTRLing();
                Instance.DAAsignarProcedure("V4MVC_CTRLING_SELECT_MDTE");
                Instance.DAAgregarParametro("@DIVISIONES", DIVISIONES, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLing();
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
        public CTRLing GetOne()
        {
            try
            {
                CTRLing item = new CTRLing();
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

        #region [ Metodos ]
        #endregion
    }
}

