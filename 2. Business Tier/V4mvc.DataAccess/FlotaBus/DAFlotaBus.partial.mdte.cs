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
	public partial class DAFlotaBus
	{
		#region [ Consultas ]
		public ObservableCollection<FlotaBus> GetListFlotaBus_Mdte(string DIVCOD)
		{
			try
			{	
				var items = new ObservableCollection<FlotaBus>();
				Instance.DAAsignarProcedure("V4MVC_FLOTA_BUS_SELECT_MDTE");
				Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.VarChar, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new FlotaBus();
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
