using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAAprobacion_SubContratos : IDAAprobacion_SubContratos
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Aprobacion_SubContratos> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAAprobacion_SubContratos(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<Aprobacion_SubContratos>();
            Aprobacion_SubContratos item = new Aprobacion_SubContratos();
            Loader.EntityType = item.GetType();
            this.Instance = container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Aprobacion_SubContratos> GetAll()
        {
            try
            {
                ObservableCollection<Aprobacion_SubContratos> items = new ObservableCollection<Aprobacion_SubContratos>();
                Aprobacion_SubContratos item = new Aprobacion_SubContratos();
                Instance.DAAsignarProcedure("_SU_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Aprobacion_SubContratos();
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
        public Aprobacion_SubContratos GetOne(Int32 ID)
        {
            try
            {
                Aprobacion_SubContratos item = new Aprobacion_SubContratos();
                Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_SELECT_ONE_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.Int, 4, ParameterDirection.Input);
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
        public bool Save(ref Aprobacion_SubContratos item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("_SU_UnReg");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("_SU_UnReg");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("V4MVC_APROBACION_SUBCONTRATOS_DELETE");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.InputOutput);
                        Instance.DAAgregarParametro("@DOTACION", item.DOTACION, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FINICIO", item.FINICIO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FTERMINO", item.FTERMINO, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@MONTO", item.MONTO, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NIVEL", item.NIVEL, SqlDbType.Int, 4, ParameterDirection.Input);
                    }

                    if (Instance.DAExecuteNonQuery() > 0)
                    {
                        return true;
                    }
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
