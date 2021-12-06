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
    public partial class DAInformes_Certificacion : IDAInformes_Certificacion
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Informes_Certificacion> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAInformes_Certificacion(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<Informes_Certificacion>();
            Informes_Certificacion item = new Informes_Certificacion();
            Loader.EntityType = item.GetType();
            Instance = container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Informes_Certificacion> GetAll(String DIVCOD)
        {
            try
            {
                ObservableCollection<Informes_Certificacion> items = new ObservableCollection<Informes_Certificacion>();
                Informes_Certificacion item = new Informes_Certificacion();
                Instance.DAAsignarProcedure("V4MVC_INFORMES_CERTIFICACION_DIVISION_SELECT");
                Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Informes_Certificacion();
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
        public Informes_Certificacion GetOne()
        {
            try
            {
                Informes_Certificacion item = new Informes_Certificacion();
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

