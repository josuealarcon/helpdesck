using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAWorkersLocal_Bono_Resumen
    {

        #region [ Consultas ]

        public ObservableCollection<WorkersLocal_Bono_Resumen> GetWorkersLocal_Bono_ResumenCtta(ref WorkersLocal_Bono_Resumen model)
        {
            try
            {
                ObservableCollection<WorkersLocal_Bono_Resumen> items = new ObservableCollection<WorkersLocal_Bono_Resumen>();
                WorkersLocal_Bono_Resumen item = new WorkersLocal_Bono_Resumen();
                Instance.DAAsignarProcedure("V4MVC_WORKERSLOCAL_BONO_RESUMEN_SELECT_CTTA");
                Instance.DAAgregarParametro("@DIVISION", model.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPO_BONO", model.TIPO_BONO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", model.PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@BONO", model.BONO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
