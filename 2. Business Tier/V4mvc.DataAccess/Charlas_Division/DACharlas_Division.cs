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
	public partial class DACharlas_Division : IDACharlas_Division
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Charlas_Division> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DACharlas_Division(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Charlas_Division>();
			var item = new Charlas_Division();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<Charlas_Division> GetAll()
		{
			try
			{
				var items = new ObservableCollection<Charlas_Division>();
				Instance.DAAsignarProcedure("V4MVC_CHARLAS_DIVISION_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Charlas_Division();
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

		public Charlas_Division GetOne(Int32 ID_CHARLA_DIVISION)
		{
			try
			{
				var item = new Charlas_Division();
				Instance.DAAsignarProcedure("V4MVC_CHARLAS_DIVISION_SELECT_ONE");
				Instance.DAAgregarParametro("@ID_CHARLA_DIVISION", ID_CHARLA_DIVISION, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ return null; }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref Charlas_Division item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_CHARLAS_DIVISION_INSERT_MDTE");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_CHARLAS_DIVISION_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_CHARLA_DIVISION", item.ID_CHARLA_DIVISION, SqlDbType.Int, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@ID_CHARLA_DIVISION"].Value != null)
						{
							item.ID_CHARLA_DIVISION = Int32.Parse(Instance.DASqlCommand.Parameters["@ID_CHARLA_DIVISION"].Value.ToString());
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

		public bool Delete(ref Charlas_Division item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_CHARLAS_DIVISION_DELETE");
					Instance.DAAgregarParametro("@ID_CHARLA_DIVISION", item.ID_CHARLA_DIVISION, SqlDbType.Int, 4, ParameterDirection.Input);
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					return false;
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
