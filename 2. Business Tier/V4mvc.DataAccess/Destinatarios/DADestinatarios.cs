using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;
using System.Data;

namespace V4mvc.DataAccess
{
    public partial class DADestinatarios : IDADestinatarios
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }
        public LoaderEntity<Destinatarios> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DADestinatarios(IDataAccessEnterprise container)
        {
            this.Instance = container;
            Loader = new LoaderEntity<Destinatarios>();
            Destinatarios item = new Destinatarios();
            Loader.EntityType = item.GetType();
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Destinatarios> GetAll(String MODULO)
        {
            try
            {
                ObservableCollection<Destinatarios> items = new ObservableCollection<Destinatarios>();
                Destinatarios item = new Destinatarios();
                Instance.DAAsignarProcedure("V4MVC_DESTINATARIOS_SELECT");
                Instance.DAAgregarParametro("@MODULO", MODULO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Destinatarios();
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
        public Destinatarios GetOne(String MODULO)
        {
            try
            {
                Destinatarios item = new Destinatarios();
                Instance.DAAsignarProcedure("V4MVC_DESTINATARIOS_SELECT");
                Instance.DAAgregarParametro("@MODULO", MODULO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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
        public bool Save(ref Destinatarios item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@MODULO", item.MODULO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@MODULO", item.MODULO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@MODULO", item.MODULO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                            break;
                    }
                    if (Instance.DAExecuteNonQuery() > 0)
                    { return true; }
                    else
                    { return false; }
                }
                else
                { return true; }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
