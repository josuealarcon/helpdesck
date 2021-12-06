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
	public partial class DADocs_Ost : IDADocs_Ost
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Docs_Ost> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DADocs_Ost(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Docs_Ost>();
			var item = new Docs_Ost();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<Docs_Ost> GetAll()
		{
			try
			{
				var items = new ObservableCollection<Docs_Ost>();
				Instance.DAAsignarProcedure("SS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Docs_Ost();
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

		public Docs_Ost GetOne(string OST)
		{
			try
			{
				var item = new Docs_Ost();
				Instance.DAAsignarProcedure("SS");
				Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 28, ParameterDirection.Input);
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

		public bool Save(ref Docs_Ost item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_DOCS_OST_INSERT_MDTE");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("SS");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@OST", item.OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MADRE", item.MADRE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NIVEL", item.NIVEL, SqlDbType.SmallInt, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRE_ARCHIVO", item.NOMBRE_ARCHIVO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPO_CONTENIDO", item.TIPO_CONTENIDO, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ARCHIVO", item.ARCHIVO, SqlDbType.Image, 2147483647, ParameterDirection.Input);
					}
					if (Instance.DAExecuteNonQuery() > 0)
					{
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
