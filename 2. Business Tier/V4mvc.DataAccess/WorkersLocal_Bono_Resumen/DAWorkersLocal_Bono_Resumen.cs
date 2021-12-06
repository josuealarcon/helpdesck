using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAWorkersLocal_Bono_Resumen : IDAWorkersLocal_Bono_Resumen
    {

        #region [ Propiedades ]

        public IUnityContainer containerService { get; set; }
        public LoaderEntity<WorkersLocal_Bono_Resumen> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }

        #endregion

        #region [ Constructores ]

        public DAWorkersLocal_Bono_Resumen(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<WorkersLocal_Bono_Resumen>();
            WorkersLocal_Bono_Resumen item = new WorkersLocal_Bono_Resumen();
            Loader.EntityType = item.GetType();
            Instance = container;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<WorkersLocal_Bono_Resumen> GetAll()
        {
            try
            {
                ObservableCollection<WorkersLocal_Bono_Resumen> items = new ObservableCollection<WorkersLocal_Bono_Resumen>();
                WorkersLocal_Bono_Resumen item = new WorkersLocal_Bono_Resumen();
                Instance.DAAsignarProcedure("_SI_UnReg");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new WorkersLocal_Bono_Resumen();
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

        public WorkersLocal_Bono_Resumen GetOne(String RUT, String DIVISION, String EMPRESA)
        {
            try
            {
                WorkersLocal_Bono_Resumen item = new WorkersLocal_Bono_Resumen();
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

        #region [ Métodos ]

        public bool Save(ref WorkersLocal_Bono_Resumen item)
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
                        Instance.DAAgregarParametro("@TIPO_BONO", item.TIPO_BONO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@PERIODO", item.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TURNO", item.TURNO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIAS_TRABAJO", item.DIAS_TRABAJO, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIAS_FAENA", item.DIAS_FAENA, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIAS_LICENCIA", item.DIAS_LICENCIA, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@TOTAL_ASISTENCIA", item.TOTAL_ASISTENCIA, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@PORCEN_ASIS_FINAL", item.PORCEN_ASIS_FINAL, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@PORCEN_ASIS_MIN", item.PORCEN_ASIS_MIN, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@BONO", item.BONO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@VALOR", item.VALOR, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USRMOD", item.USRMOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@CERRADO", item.CERRADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHA_CIERRE", item.FECHA_CIERRE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORA_CIERRE", item.HORA_CIERRE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO_CIERRE", item.USUARIO_CIERRE, SqlDbType.NVarChar, 12, ParameterDirection.Input);
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