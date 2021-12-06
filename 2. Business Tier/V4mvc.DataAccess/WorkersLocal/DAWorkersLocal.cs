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
    public partial class DAWorkersLocal : IDAWorkersLocal
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<WorkersLocal> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAWorkersLocal(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<WorkersLocal>();
            WorkersLocal item = new WorkersLocal();
            Loader.EntityType = item.GetType();
            Instance = container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<WorkersLocal> GetAll()
        {
            try
            {
                ObservableCollection<WorkersLocal> items = new ObservableCollection<WorkersLocal>();
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("_SI_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WorkersLocal();
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
        public WorkersLocal GetOne(String RUT, String DIVISION, String EMPRESA)
        {
            try
            {
                WorkersLocal item = new WorkersLocal();
                Instance.DAAsignarProcedure("_SI_UnReg");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
        public bool Save(ref WorkersLocal item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("_SU_UnReg");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@LOTE", item.LOTE, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPOPASE", item.TIPOPASE, SqlDbType.NVarChar, 9, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FINIPASE", item.FINIPASE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FFINPASE", item.FFINPASE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHARLA", item.FECHARLA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@AUTOR", item.AUTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@QUIEN", item.QUIEN, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@VALIDADO", item.VALIDADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TIPOCONTRATO", item.TIPOCONTRATO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CONDUCTOR", item.CONDUCTOR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ALIMENTACION", item.ALIMENTACION, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@IDSYNC", item.IDSYNC, SqlDbType.BigInt, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@IDGERENCIA", item.IDGERENCIA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ESTADOCERTIFICACION", item.ESTADOCERTIFICACION, SqlDbType.NVarChar, -1, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@REMU", item.REMU, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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
