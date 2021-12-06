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
	public partial class DATabEstadoPase : IDATabEstadoPase
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<TabEstadoPase> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DATabEstadoPase(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<TabEstadoPase>();
			var item = new TabEstadoPase();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<TabEstadoPase> GetAll()
		{
			try
			{
				var items = new ObservableCollection<TabEstadoPase>();
				Instance.DAAsignarProcedure("V4MVC_TAB_ESTADO_PASE_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new TabEstadoPase();
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

		public TabEstadoPase GetOne(string ESTADO_PASE)
		{
			try
			{
				var item = new TabEstadoPase();
				Instance.DAAsignarProcedure("__ISS");
				Instance.DAAgregarParametro("@ESTADO_PASE", ESTADO_PASE, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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

		public bool Save(ref TabEstadoPase item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("__ISS");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("__ISS");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ESTADO_PASE", item.ESTADO_PASE, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESC_ESTADO", item.DESC_ESTADO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ESTADO_PASE", item.ESTADO_PASE, SqlDbType.NVarChar, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@ESTADO_PASE"].Value != null)
						{
							item.ESTADO_PASE = (Instance.DASqlCommand.Parameters["@ESTADO_PASE"].Value.ToString());
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

		public bool Delete(ref TabEstadoPase item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("__ISS");
					Instance.DAAgregarParametro("@ESTADO_PASE", item.ESTADO_PASE, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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
