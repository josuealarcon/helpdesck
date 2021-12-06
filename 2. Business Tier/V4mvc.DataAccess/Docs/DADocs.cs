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
    public partial class DADocs : IDADocs
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Docs> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        private readonly IDbFactory _dbFactory;
        #endregion

        #region [ Constructores ]
        public DADocs(IDataAccessEnterprise dbFactory)
        {
            //Instance = container;
            Loader = new LoaderEntity<Docs>();
            Docs item = new Docs();
            Loader.EntityType = item.GetType();
            Instance = dbFactory;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs> GetAll()
        {
            try
            {
                ObservableCollection<Docs> items = new ObservableCollection<Docs>();
                //Docs item = new Docs();

                //Instance.DAAsignarProcedure("_ID_DSS");
                //using (IDataReader reader = Instance.DAExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        item = new Docs();
                //        Loader.LoadEntity(reader, item);
                //        item.Instance = InstanceEntity.Unchanged;
                //        items.Add(item);
                //    }
                //}
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs GetOne(int ID_DOC)
        {
            try
            {
                Docs item = new Docs();
                Instance.DAAsignarProcedure("V4MVC_DOCS_SELECT");
                Instance.DAAgregarParametro("@ID_DOC", ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
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
        public bool Save(ref Docs item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            //Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                        case InstanceEntity.Modify:
                            //Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                        case InstanceEntity.Delete:
                            //Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        //Instance.DAAgregarParametro("@ID_DOC", item.ID_DOC, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@RUTA", item.RUTA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@CAMPO", item.CAMPO, SqlDbType.NVarChar, 30, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ID_DOC_OPCION", item.ID_DOC_OPCION, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ID_TIPO_PROPIETARIO", item.ID_TIPO_PROPIETARIO, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@CONFIDENCIAL", item.CONFIDENCIAL, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@IDENTIFICADOR_FOTO", item.IDENTIFICADOR_FOTO, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@SUBEDOC", item.SUBEDOC, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@WHOUPDATE", item.WHOUPDATE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@SHORT", item.SHORT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ORDEN", item.ORDEN, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@COMUN", item.COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ESPECIFICO", item.ESPECIFICO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@URL_ESPECIFICO", item.URL_ESPECIFICO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@URL_CTRLLABORAL", item.URL_CTRLLABORAL, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@COMUN_DIV", item.COMUN_DIV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@URLDONDE", item.URLDONDE, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@URLCOMO", item.URLCOMO, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@PORCENTAJE_AUDIT", item.PORCENTAJE_AUDIT, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@VALIDAMANDANTE", item.VALIDAMANDANTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ESPECIFICO_VER_OST", item.ESPECIFICO_VER_OST, SqlDbType.Char, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ESPECIFICO_VER_RESOLUCION", item.ESPECIFICO_VER_RESOLUCION, SqlDbType.Char, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@ID_TIPO_ESPECIFICO", item.ID_TIPO_ESPECIFICO, SqlDbType.Int, 4, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@VALIDASUBCONTRATISTA", item.VALIDASUBCONTRATISTA, SqlDbType.Char, 2, ParameterDirection.Input);
                        //Instance.DAAgregarParametro("@TIPODOC_AUDIT", item.TIPODOC_AUDIT, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                    }


                    //if (Instance.DAExecuteNonQuery() > 0)
                    //{ return true; }
                    //else
                    //{ return false; }
                    return true;
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
