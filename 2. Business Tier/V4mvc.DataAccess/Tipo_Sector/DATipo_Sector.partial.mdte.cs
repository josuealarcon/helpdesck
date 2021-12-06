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
	public partial class DATipo_Sector
	{
        #region [ Consultas ]

        public ObservableCollection<Tipo_Sector> GetAllTipoSector_Mdte()
        {
            try
            {
                ObservableCollection<Tipo_Sector> items = new ObservableCollection<Tipo_Sector>();
                Tipo_Sector item = new Tipo_Sector();
                Instance.DAAsignarProcedure("V4MVC_TIPO_SECTOR_SELECT_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Tipo_Sector();
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
