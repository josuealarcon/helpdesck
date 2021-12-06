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
	public partial class DALiquidacion_Disputa
	{
        #region [ Consultas ]
        public ObservableCollection<Liquidacion_Disputa> GetListliquidacionDisputaDocsApoyo_Mdte(string RUT, int ID_DISPUTA, string FECHA)
        {
            try
            {
                ObservableCollection<Liquidacion_Disputa> items = new ObservableCollection<Liquidacion_Disputa>();
                Liquidacion_Disputa item = new Liquidacion_Disputa();
                Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_DISPUTA_SELECT_ALL_DOCS_APOYO_LIQUIDACION_MDTE");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ID_DISPUTA", ID_DISPUTA, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@FECHA", FECHA, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Liquidacion_Disputa();
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
