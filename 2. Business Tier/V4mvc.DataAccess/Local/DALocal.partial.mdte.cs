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
	public partial class DALocal
	{
		#region [ Consultas ]

		public ObservableCollection<Local> GetAllLocal_v2_PasesMdte(string RUT, string DIVISION, int IDPASE, string ID_EMPRESA)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();

				Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_SELECT_PASES_MDTE");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIVCOD", DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ID_PASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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

		public ObservableCollection<Local> GetAllLocal_PasesMdte(string DIVCOD)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_LOCAL_SELECT_PASES_MDTE");
				Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
