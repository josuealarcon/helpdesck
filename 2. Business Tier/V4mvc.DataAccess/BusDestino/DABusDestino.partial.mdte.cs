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
	public partial class DABusDestino
	{
		#region [ Consultas ]

		public ObservableCollection<BusDestino> GetListBusDestino_Mdte(string DIVCOD)
		{
			try
			{
				ObservableCollection<BusDestino> items = new ObservableCollection<BusDestino>();
				BusDestino item = new BusDestino();
				Instance.DAAsignarProcedure("V4MVC_BUSDESTINO_SELECT_MDTE");
				Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new BusDestino();
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
