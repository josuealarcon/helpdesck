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
   public partial class DADivisiones
    {
        #region[ Consultas ]
        public ObservableCollection<Divisiones> GetListDivision_Mdte( string DIVISIONES)
        {
            try
            {
                Divisiones division = new Divisiones();
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Instance.DAAsignarProcedure("V4MVC_OSTSUBC_SELECT_DIVISIONES_MDTE");
                Instance.DAAgregarParametro("@DIVISIONES", DIVISIONES, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        division = new Divisiones();
                        Loader.LoadEntity(reader, division);
                        division.Instance = InstanceEntity.Unchanged;
                        items.Add(division);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Divisiones> GetListDivisiones_Mdte()
        {
            try
            {
                ObservableCollection<Divisiones> items = new ObservableCollection<Divisiones>();
                Divisiones item = new Divisiones();
                Instance.DAAsignarProcedure("V4MVC_DIVISIONES_SELECT_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Divisiones();
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
    }
}
