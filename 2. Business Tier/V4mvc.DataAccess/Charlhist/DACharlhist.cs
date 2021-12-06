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
	public partial class DACharlhist : IDACharlhist
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Charlhist> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		#endregion

		#region [ Constructores ]
		public DACharlhist(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Charlhist>();
			Charlhist item = new Charlhist();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Charlhist> GetAll()
		{
			try
			{
				ObservableCollection<Charlhist> items = new ObservableCollection<Charlhist>();
				Charlhist item = new Charlhist();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Charlhist();
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
		public Charlhist GetOne(Int32 IDCHARLA)
		{
			try
			{
				Charlhist item = new Charlhist();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@IDCHARLA", IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
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
		public bool Save(ref Charlhist item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@CHARLA", item.CHARLA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LOCAL", item.LOCAL, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ORADOR", item.ORADOR, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TEORICO", item.TEORICO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PRACTICO", item.PRACTICO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBS", item.OBS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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