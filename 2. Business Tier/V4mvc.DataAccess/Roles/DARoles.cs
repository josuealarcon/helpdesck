using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DARoles : IDARoles
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Roles> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DARoles(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Roles>();
			Roles item = new Roles();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Roles> GetAll()
		{
			try
			{
				ObservableCollection<Roles> items = new ObservableCollection<Roles>();
				Roles item = new Roles();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Roles();
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
		public Roles GetOne(String ROL, String AREA, String PROCESO, String SUBPROCESO)
		{
			try
			{
				Roles item = new Roles();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@ROL", ROL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@AREA", AREA, SqlDbType.NVarChar, 60, ParameterDirection.Input);
				Instance.DAAgregarParametro("@PROCESO", PROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SUBPROCESO", SUBPROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
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
		public bool Save(ref Roles item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ROL", item.ROL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
							Instance.DAAgregarParametro("@AREA", item.AREA, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							Instance.DAAgregarParametro("@PROCESO", item.PROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							Instance.DAAgregarParametro("@SUBPROCESO", item.SUBPROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@ROL", item.ROL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
							Instance.DAAgregarParametro("@AREA", item.AREA, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							Instance.DAAgregarParametro("@PROCESO", item.PROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							Instance.DAAgregarParametro("@SUBPROCESO", item.SUBPROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ROL", item.ROL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
							Instance.DAAgregarParametro("@AREA", item.AREA, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							Instance.DAAgregarParametro("@PROCESO", item.PROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							Instance.DAAgregarParametro("@SUBPROCESO", item.SUBPROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CODIGOROL", item.CODIGOROL, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@msrepl_tran_version", item.msrepl_tran_version, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
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
