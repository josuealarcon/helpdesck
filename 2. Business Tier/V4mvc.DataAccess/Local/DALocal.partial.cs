using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DALocal
	{
		#region [ Consultas ]
		public ObservableCollection<Local> GetAllLocal_PasesCtta(string DIVCOD)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_LOCAL_SELECT_PASES_CTTA");
				Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
		
		public ObservableCollection<Local> GetAllLocalAcceso_PasesCtta(string DIVCOD)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_LOCAL_SELECT_PASESACCESOS_CTTA");
				Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
		public ObservableCollection<Local> GetAllLocal_v2_PasesCtta(string RUT, string DIVISION, int IDPASE, string ID_EMPRESA)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();

				Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_SELECT_PASES_CTTA");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIVCOD", DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ID_PASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
		
		public ObservableCollection<Local> GetAllLocalAcceso_v2_PasesCtta(string RUT, string DIVISION, int IDPASE, string ID_EMPRESA)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();

				Instance.DAAsignarProcedure("V4MVC_WORKERS_ZONA_PASE_SELECT_PASESACCESOS_CTTA");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@DIVCOD", DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ID_PASE", IDPASE, SqlDbType.Int, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", ID_EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
		public ObservableCollection<Local> GetAllLocalesPorDiv_Informe(string DIVCOD, string LOCALL)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();

				Instance.DAAsignarProcedure("V4MVC_LOCALS_BY_DIVCOD_INFORME");
				Instance.DAAgregarParametro("@DIVCOD", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LOCALL", LOCALL, SqlDbType.NVarChar, 10, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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

		public ObservableCollection<Local> GetLocalDivisionCtta(string DIVCOD)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_LOCAL_DIVISION_CTTA");
				Instance.DAAgregarParametro("@DIVISION", DIVCOD, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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

		public ObservableCollection<Local> GetLocalesCasinoCtta(string RUT)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_LOCAL_SELECT_CASINO_CTTA");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
		public ObservableCollection<Local> GetListLocalesCasinoPermitidos_Ctta(string RUT)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_LOCAL_SELECT_CASINO_CTTA");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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

		public ObservableCollection<Local> GetListLocalesCasinoPermitidosAutorizaciones_Ctta()
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_LOCALL_SELECT_LOCAL_CASINO_PERMITIDO_CTTA");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
		public ObservableCollection<Local> GetListServiciosCheckedCasinoPermitidosAutorizaciones_Ctta(string RUT, string LOCAL)
		{
			try
			{
				ObservableCollection<Local> items = new ObservableCollection<Local>();
				Local item = new Local();
				Instance.DAAsignarProcedure("V4MVC_SERVICIO_SELECT_LOCAL_CASINO_PERMITIDO_CTTA");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LOCAL", LOCAL, SqlDbType.NVarChar, 20, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Local();
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
		#endregion

		#region [ Metodos ]
		public bool SaveLocalCasino_Ctta(Local casino) {
			try
			{
				Instance.DAAsignarProcedure("V4MVC_WORKERSCASINO_INSERT_CASINO_CTTA");
				Instance.DAAgregarParametro("@RUT", casino.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", casino.IDEMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LOCAL", casino.LOCAL, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@SERVICIO", casino.SERVICIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public bool DeleteLocalCasino_Ctta(string RUT)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_WORKERSCASINO_DELETE_CASINO_CTTA");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		#endregion
	}
}
