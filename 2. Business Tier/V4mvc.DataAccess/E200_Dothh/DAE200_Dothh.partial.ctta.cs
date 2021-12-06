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
	public partial class DAE200_Dothh
	{
        #region [ Consultas ]
        public ObservableCollection<E200_Dothh> GetSubContratistasE200Dot_Ctta(string OST)
        {
            try
            {
                ObservableCollection<E200_Dothh> items = new ObservableCollection<E200_Dothh>();
                E200_Dothh item = new E200_Dothh();
                Instance.DAAsignarProcedure("V4MVC_E200_Dothh_SELECT_NIVELNO0_CTTA");
                Instance.DAAgregarParametro("@NROOST", OST, SqlDbType.NVarChar, 28, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new E200_Dothh();
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
        public ObservableCollection<E200_Dothh> GetAllE200_Datos_Dothh_SubcontratistaCtta(Guid ID)
        {
            try
            {
                var items = new ObservableCollection<E200_Dothh>();
                Instance.DAAsignarProcedure("V4MVC_E200_DATOS_DOTHH_SUCONTRATISTA_SELECT_LISTADOCTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new E200_Dothh();
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
        public bool Save_E200_Dothh_Ctta(ref E200_Dothh item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_E200_DOTHH_INSERT_CTTA");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDEMPRESA", item.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTHOM", item.DOTHOM.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HHHOM", item.HHHOM.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOTMUJ", item.DOTMUJ.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HHMUJ", item.HHMUJ.Value, SqlDbType.Int, 4, ParameterDirection.Input);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{

						if (Instance.DASqlCommand.Parameters["@ID"].Value != null)
						{
							item.ID = Guid.Parse(Instance.DASqlCommand.Parameters["@ID"].Value.ToString());
						}
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
