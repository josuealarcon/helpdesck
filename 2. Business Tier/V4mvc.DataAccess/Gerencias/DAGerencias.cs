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
	public partial class DAGerencias : IDAGerencias
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Gerencias> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DAGerencias(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Gerencias>();
			var item = new Gerencias();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<Gerencias> GetAll()
		{
			try
			{
				var items = new ObservableCollection<Gerencias>();
				Instance.DAAsignarProcedure("V4MVC_GERENCIAS_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Gerencias();
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

		public Gerencias GetOne(Int32 IDGERENCIA)
		{
			try
			{
				var item = new Gerencias();
				Instance.DAAsignarProcedure("V4MVC_GERENCIAS_SELECT_ONE");
				Instance.DAAgregarParametro("@IDGERENCIA", IDGERENCIA, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool Save(ref Gerencias item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_GERENCIAS_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_GERENCIAS_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@GERENCIA", item.GERENCIA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDGENERAL", item.IDGENERAL.Value, SqlDbType.Decimal, 9, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDGERENCIA", item.IDGERENCIA, SqlDbType.Int, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@IDGERENCIA"].Value != null)
						{
							item.IDGERENCIA = Int32.Parse(Instance.DASqlCommand.Parameters["@IDGERENCIA"].Value.ToString());
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

		public bool Delete(ref Gerencias item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_GERENCIAS_DELETE");
					Instance.DAAgregarParametro("@IDGERENCIA", item.IDGERENCIA, SqlDbType.Int, 4, ParameterDirection.Input);
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
