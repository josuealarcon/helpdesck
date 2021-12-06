using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DARol : IDARol
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Rol> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DARol(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Rol>();
			Rol item = new Rol();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Rol> GetAll()
		{
			try
			{
				ObservableCollection<Rol> items = new ObservableCollection<Rol>();
				Rol item = new Rol();
				Instance.DAAsignarProcedure("ROL_ID_RSS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Rol();
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
		public Rol GetOne(Int32 ID_ROL)
		{
			try
			{
				Rol item = new Rol();
				Instance.DAAsignarProcedure("ROL_ID_RSS");
				Instance.DAAgregarParametro("@ID_ROL", ID_ROL, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ throw new Exception("No se encontro el registro."); }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool Save(ref Rol item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("ROL_ID_RSI_UnReg");
							Instance.DAAgregarParametro("@ID_ROL", item.ID_ROL, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID_ROL", item.ID_ROL, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("ROL_ID_RSD_UnReg");
							Instance.DAAgregarParametro("@ID_ROL", item.ID_ROL, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ROL", item.ROL, SqlDbType.NVarChar, 200, ParameterDirection.Input);
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
