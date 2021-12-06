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
	public partial class DACharlas : IDACharlas
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Charlas> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
		#endregion
		
		#region [ Constructores ]
		public DACharlas(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Charlas>();
			Charlas item = new Charlas();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Charlas> GetAll()
		{
			try
			{
				ObservableCollection<Charlas> items = new ObservableCollection<Charlas>();
				Charlas item = new Charlas();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Charlas();
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
		public Charlas GetOne(Int32 IDCHARLA)
		{
			try
			{
				Charlas item = new Charlas();
				Instance.DAAsignarProcedure("V4MVC_CHARLAS_SELECT_CTTA");
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
		public bool Save(ref Charlas item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@CHARLA", item.CHARLA, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCRIP", item.DESCRIP, SqlDbType.NVarChar, 60, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAS", item.HORAS, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VENCIMIENTO", item.VENCIMIENTO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AREA", item.AREA, SqlDbType.NVarChar, 60, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PROCESO", item.PROCESO, SqlDbType.NVarChar, 60, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VENCE", item.VENCE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 1, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC_FEC", item.ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CAMPOFEC", item.CAMPOFEC, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBLIGATORIO", item.OBLIGATORIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_AREA", item.ID_AREA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PORCENTAJE", item.PORCENTAJE, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_CLASIFIACION", item.ID_CLASIFIACION, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_AMBITO", item.ID_AMBITO, SqlDbType.Int, 4, ParameterDirection.Input);
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
