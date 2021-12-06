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
	public partial class DABusOrigen
	{
		#region [ Consultas ]
		public ObservableCollection<BusOrigen> GetListBusOrigen_Mdte(string DIVCOD)
		{
			try
			{
				ObservableCollection<BusOrigen> items = new ObservableCollection<BusOrigen>();
				BusOrigen item = new BusOrigen();
				Instance.DAAsignarProcedure("V4MVC_BUSORIGEN_SELECT_MDTE");
				Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new BusOrigen();
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
