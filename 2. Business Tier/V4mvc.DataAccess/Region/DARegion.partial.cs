
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
    public partial class DARegion
    {
        #region [ Consultas ]
        public ObservableCollection<Region> GetAllRegion_ControlLaboralCtta(string PAIS)
        {
            try
            {
                ObservableCollection<Region> items = new ObservableCollection<Region>();
                Region item = new Region();
                Instance.DAAsignarProcedure("V4MVC_REGION_SELECT_CONTROLLABORAL_CTTA");
                Instance.DAAgregarParametro("@PAIS", PAIS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Region();
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
	