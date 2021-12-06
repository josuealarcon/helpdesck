using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAProgBus
    {
        #region [ Consultas ]
        public ObservableCollection<ProgBus> GetListBusesProgramacion_mdte(ProgBus ProgBus)
        {
            try
            {
                ObservableCollection<ProgBus> items = new ObservableCollection<ProgBus>();
                ProgBus item = new ProgBus();
                Instance.DAAsignarProcedure("V4MVC_PROGBUS_SELECT_CHARLAS_MDTE");
                Instance.DAAgregarParametro("@START", ProgBus.START, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@LENGTH", ProgBus.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@COLUMN", ProgBus.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIRECTION", ProgBus.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", ProgBus.COL1, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PATENTE", ProgBus.COL2, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ORIGEN", ProgBus.COL3, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESTINO", ProgBus.COL4, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", ProgBus.COL5, SqlDbType.Int, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HORA", ProgBus.COL6, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DURACION", ProgBus.COL7, SqlDbType.NVarChar, 4, ParameterDirection.Input);


                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new ProgBus();
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

        #region [ Metodos ]
    }  
    #endregion
}
