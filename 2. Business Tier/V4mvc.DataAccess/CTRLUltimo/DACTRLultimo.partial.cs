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
    public partial class DACTRLultimo
    {
        #region [ Consultas ]
        #endregion
        #region [ Informes ]

        public ObservableCollection<CTRLultimo> GetWorkers_GridMovimientos_FichaRut_InformeConsultaRapidaCtta(CTRLultimo Item)
        {
            try
            {
                ObservableCollection<CTRLultimo> items = new ObservableCollection<CTRLultimo>();
                CTRLultimo item = new CTRLultimo();
                Instance.DAAsignarProcedure("V4MVC_WORKERS_SELECT_GRID_MOVIMIENTOS_FICHARUT_INFORMECONSULTARAPIDA_CTTA");
                Instance.DAAgregarParametro("@RUT", Item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CTRLultimo();
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
        #endregion
    }
}