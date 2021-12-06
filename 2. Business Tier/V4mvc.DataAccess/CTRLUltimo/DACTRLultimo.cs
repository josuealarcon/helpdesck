using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DACTRLultimo : IDACTRLultimo
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<CTRLultimo> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DACTRLultimo(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<CTRLultimo>();
            CTRLultimo item = new CTRLultimo();
            Loader.EntityType = item.GetType();
            Instance = container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<CTRLultimo> GetAll(String DIVISIONES)
        {
            try
            {
                ObservableCollection<CTRLultimo> items = new ObservableCollection<CTRLultimo>();
                CTRLultimo item = new CTRLultimo();
                Instance.DAAsignarProcedure("V4MVC_FAENADIVISION_SELECT_MDTE");
                Instance.DAAgregarParametro("@DIVISIONES", DIVISIONES, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLultimo();
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
        public CTRLultimo GetOne()
        {
            try
            {
                CTRLultimo item = new CTRLultimo();
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

