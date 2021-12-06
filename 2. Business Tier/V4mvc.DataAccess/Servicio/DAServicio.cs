using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DAServicio : IDAServicio
	{

		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Servicio> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }

		#endregion

		#region [ Constructores ]

		public DAServicio(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Servicio>();
			Servicio item = new Servicio();
			Loader.EntityType = item.GetType();
			Instance = container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Servicio> GetAll()
		{
			try
			{
				ObservableCollection<Servicio> items = new ObservableCollection<Servicio>();
				Servicio item = new Servicio();
				Instance.DAAsignarProcedure("_RSS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Servicio();
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

		public Servicio GetOne(string SERVICIO)
		{
			try
			{
				Servicio item = new Servicio();
				Instance.DAAsignarProcedure("_RSS");
				Instance.DAAgregarParametro("@SERVICIO", SERVICIO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
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

		#region [ Métodos ]

		public bool Save(ref Servicio item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("SI_UnReg");
							Instance.DAAgregarParametro("@SERVICIO", item.SERVICIO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("SU_UnReg");
							Instance.DAAgregarParametro("@SERVICIO", item.SERVICIO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("SD_UnReg");
							Instance.DAAgregarParametro("@ID_Servicio", item.SERVICIO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIPOSERVICIO", item.TIPOSERVICIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VALOR", item.VALOR, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAINI", item.HORAINI, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAFIN", item.HORAFIN, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LOCAL", item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REEMPLAZO", item.REEMPLAZO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MAXDIA", item.MAXDIA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDSYNC", item.IDSYNC, SqlDbType.BigInt, 8, ParameterDirection.Input);
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