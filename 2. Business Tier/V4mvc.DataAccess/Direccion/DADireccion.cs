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
    public partial class DADireccion : IDADireccion
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Direccion> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DADireccion(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<Direccion>();
            Direccion item = new Direccion();
            Loader.EntityType = item.GetType();
            Instance = container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Direccion> GetAll()
        {
            try
            {
                ObservableCollection<Direccion> items = new ObservableCollection<Direccion>();
                Direccion item = new Direccion();
                Instance.DAAsignarProcedure("_SI_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Direccion();
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
        public Direccion GetOne(String RUT)
        {
            try
            {
                Direccion item = new Direccion();
                Instance.DAAsignarProcedure("V4MVC_DIRECCION_SELECT");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
        public bool Save(ref Direccion item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_DIRECCION_INSERT");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_DIRECCION_UPDATE");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIRECCION", item.DIRECCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@COMUNA", item.COMUNA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CIUDAD", item.CIUDAD, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@REGION", item.REGION, SqlDbType.NVarChar, 5, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@PAIS", item.PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FONOHELP", item.FONOHELP, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FONO", item.FONO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CELULAR", item.CELULAR, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPO", item.TIPO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@NOMCONTACTO", item.NOMCONTACTO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CELCONTACTO", item.CELCONTACTO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@EMAIL", item.EMAIL, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
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
