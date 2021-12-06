using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DACcostos : IDACcostos
	{

		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Ccostos> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }

		#endregion

		#region [ Constructores ]

		public DACcostos(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Ccostos>();
			Ccostos item = new Ccostos();
			Loader.EntityType = item.GetType();
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Ccostos> GetAll()
		{
			try
			{
				ObservableCollection<Ccostos> items = new ObservableCollection<Ccostos>();
				Ccostos item = new Ccostos();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Ccostos();
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

		public Ccostos GetOne(string EMPRESA, string CCOSTO)
		{
			try
			{
				Ccostos item = new Ccostos();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CCOSTO", CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
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

		#region [ Métodos ]

		public bool Save(ref Ccostos item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@CCOSTO", item.CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@CCOSTO", item.CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@CCOSTO", item.CCOSTO, SqlDbType.NVarChar, 14, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RESPONSABLE", item.RESPONSABLE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LOCALASISTENCIA", item.LOCALASISTENCIA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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
