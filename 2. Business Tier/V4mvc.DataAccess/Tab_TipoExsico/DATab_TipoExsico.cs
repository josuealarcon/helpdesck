using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DATab_TipoExsico : IDATab_TipoExsico
    {

        #region [ Propiedades ]

        public IUnityContainer ContainerService { get; set; }
        public LoaderEntity<Tab_TipoExsico> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }

        #endregion

        #region [ Constructores ]

        public DATab_TipoExsico(IDataAccessEnterprise container)
        {
            this.Instance = container;
            Loader = new LoaderEntity<Tab_TipoExsico>();
            Tab_TipoExsico item = new Tab_TipoExsico();
            Loader.EntityType = item.GetType();
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Tab_TipoExsico> GetAll()
        {
            try
            {
                ObservableCollection<Tab_TipoExsico> items = new ObservableCollection<Tab_TipoExsico>();
                Tab_TipoExsico item = new Tab_TipoExsico();
                Instance.DAAsignarProcedure("V4MVC_TAB_TIPOEXSICO_SELECT");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Tab_TipoExsico();
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

        public Tab_TipoExsico GetOne(Decimal ID)
        {
            try
            {
                Tab_TipoExsico item = new Tab_TipoExsico();
                Instance.DAAsignarProcedure("V4MVC_TAB_TIPOEXSICO_SELECT");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { throw new Exception("No se encontro el registro."); }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        public bool Save(ref Tab_TipoExsico item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("_SU_UnReg");
                            Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIOMOD", item.USUARIOMOD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DURACION", item.DURACION, SqlDbType.Int, 4, ParameterDirection.Input);
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
