using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAA036_CursoProg_Docs : IDAA036_CursoProg_Docs
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<A036_CursoProg_Docs> Loader { get; set; }

		public IDataAccessEnterprise Instance { get; set; }
		#endregion

		#region [ Constructores ]
		public DAA036_CursoProg_Docs(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<A036_CursoProg_Docs>();
			A036_CursoProg_Docs item = new A036_CursoProg_Docs();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<A036_CursoProg_Docs> GetAll()
		{
			try
			{
				ObservableCollection<A036_CursoProg_Docs> items = new ObservableCollection<A036_CursoProg_Docs>();
				A036_CursoProg_Docs item = new A036_CursoProg_Docs();
				Instance.DAAsignarProcedure("");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new A036_CursoProg_Docs();
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
		public A036_CursoProg_Docs GetOne(Guid Codigo)
		{
			try
			{
				A036_CursoProg_Docs item = new A036_CursoProg_Docs();
				Instance.DAAsignarProcedure("_SI_UnReg");
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
		public bool Save(ref A036_CursoProg_Docs item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@MOTIVO", item.ID_DOC_CHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GLOSA", item.NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ID, SqlDbType.Int, 4, ParameterDirection.Input);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
