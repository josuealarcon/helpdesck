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
	public partial class DAEvaluacionesOficio : IDAEvaluacionesOficio
	{
		#region [ Propiedades ]

		public IUnityContainer containerService { get; set; }
		public LoaderEntity<EvaluacionesOficio> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		
		#endregion

		#region [ Constructores ]

		public DAEvaluacionesOficio(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<EvaluacionesOficio>();
			var item = new EvaluacionesOficio();
			Loader.EntityType = item.GetType();
			Instance = container;
		}
		
		#endregion

		#region [ Consultas ]

		public ObservableCollection<EvaluacionesOficio> GetAll(ref EvaluacionesOficio evaluacionesOficio)
		{
			try
			{
				var items = new ObservableCollection<EvaluacionesOficio>();
				Instance.DAAsignarProcedure("V4MVC_A036_EVALUAC_FC_SELECT_MDTE");
				Instance.DAAgregarParametro("@START", evaluacionesOficio.START, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LENGTH", evaluacionesOficio.LENGTH, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@COLUMN", evaluacionesOficio.COLUMN, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIRECTION", evaluacionesOficio.DIRECTION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CHARLA", evaluacionesOficio.COL0, SqlDbType.NVarChar, 100, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DESCRIP", evaluacionesOficio.COL1, SqlDbType.NVarChar, 120, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIVISION", evaluacionesOficio.COL2, SqlDbType.NVarChar, 40, ParameterDirection.Input);
				Instance.DAAgregarParametro("@HORAS", evaluacionesOficio.COL3, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@VENCIMIENTO", evaluacionesOficio.COL4, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIVISIONES", evaluacionesOficio.DIVISIONES, SqlDbType.NVarChar, 100, ParameterDirection.Input);
				
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new EvaluacionesOficio();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				evaluacionesOficio.COUNT = items.Count > 0 ? items[0].COUNT : 0;
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public EvaluacionesOficio GetOne(Int32 IDCHARLA)
		{
			try
			{
				var item = new EvaluacionesOficio();
				Instance.DAAsignarProcedure("V4MVC_A036_EVALUAC_FC_SELECT_ONE");
				Instance.DAAgregarParametro("@IDCHARLA", IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
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

		public bool Save(ref EvaluacionesOficio item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_A036_EVALUAC_FC_INSERT_MDTE");
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_A036_EVALUAC_FC_UPDATE_MDTE");
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("V4MVC_A036_EVALUAC_FC_DELETE_MDTE");
							Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
							break;

					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@CHARLA", item.CHARLA, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESCRIP", item.DESCRIP, SqlDbType.NVarChar, 120, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAS", item.HORAS.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VENCIMIENTO", item.VENCIMIENTO.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AREA", item.AREA, SqlDbType.NVarChar, 120, ParameterDirection.Input);
						Instance.DAAgregarParametro("@PROCESO", item.PROCESO, SqlDbType.NVarChar, 120, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VENCE", item.VENCE, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@GRABO", item.GRABO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC_FEC", item.ID_DOC_FEC.Value, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 40, ParameterDirection.Input);
						Instance.DAAgregarParametro("@CAMPOFEC", item.CAMPOFEC, SqlDbType.NVarChar, 16, ParameterDirection.Input);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{
						if (Instance.DASqlCommand.Parameters["@IDCHARLA"].Value != null)
						{
							item.IDCHARLA = Int32.Parse(Instance.DASqlCommand.Parameters["@IDCHARLA"].Value.ToString());
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

		public bool Delete(ref EvaluacionesOficio item)
		{
			try
			{
				if (item.Instance == InstanceEntity.Delete)
				{
					Instance.DAAsignarProcedure("V4MVC_A036_EVALUAC_FC_DELETE");
					Instance.DAAgregarParametro("@IDCHARLA", item.IDCHARLA, SqlDbType.Int, 4, ParameterDirection.Input);
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
