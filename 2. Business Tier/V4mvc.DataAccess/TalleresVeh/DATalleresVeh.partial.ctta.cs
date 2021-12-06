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
	public partial class DATalleresVeh
	{
        #region [ Consultas ]
        public ObservableCollection<TalleresVeh> GetListTalleresVeh_Ctta(string MARCA)
        {
            try
            {
                var items = new ObservableCollection<TalleresVeh>();
                Instance.DAAsignarProcedure("V4MVC_TALLERES_VEH_SELECT_CTTA");
                Instance.DAAgregarParametro("@MARCA", MARCA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new TalleresVeh();
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
