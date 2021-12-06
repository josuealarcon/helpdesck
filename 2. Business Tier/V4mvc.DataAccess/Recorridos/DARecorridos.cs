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
	public partial class DARecorridos : IDARecorridos
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Recorridos> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DARecorridos(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Recorridos>();
			var item = new Recorridos();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<Recorridos> GetAll()
		{
			try
			{
				var items = new ObservableCollection<Recorridos>();
				Instance.DAAsignarProcedure("V4MVC_RECORRIDOS_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Recorridos();
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

		public Recorridos GetOne(Int32 IDRECORRIDO)
		{
			try
			{
				var item = new Recorridos();
				Instance.DAAsignarProcedure("V4MVC_RECORRIDOS_SELECT_ONE");
				Instance.DAAgregarParametro("@IDRECORRIDO", IDRECORRIDO, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool Save(ref Recorridos item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_RECORRIDOS_INSERT");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_RECORRIDOS_UPDATE");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@RECORRIDO", item.RECORRIDO, SqlDbType.NVarChar, 200, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CAPACIDAD_LIBERA", item.CAPACIDAD_LIBERA.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDRECORRIDO", item.IDRECORRIDO, SqlDbType.Int, 4, ParameterDirection.Output);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						
						if (Instance.DASqlCommand.Parameters["@IDRECORRIDO"].Value != null)
						{
							item.IDRECORRIDO = Int32.Parse(Instance.DASqlCommand.Parameters["@IDRECORRIDO"].Value.ToString());
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

		public bool Delete(ref Recorridos item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_RECORRIDOS_DELETE");
					Instance.DAAgregarParametro("@IDRECORRIDO", item.IDRECORRIDO, SqlDbType.Int, 4, ParameterDirection.Input);
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
