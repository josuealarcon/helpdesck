using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAReservas_Exsico
    {

		#region [ Consultas ]

		public ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoCtta(string FECHARES)
		{
			try
			{
				ObservableCollection<Reservas_Exsico> items = new ObservableCollection<Reservas_Exsico>();
				Reservas_Exsico item = new Reservas_Exsico();
				Instance.DAAsignarProcedure("V4MVC_RESERVAS_EXSICO_SELECT_CTTA");
				Instance.DAAgregarParametro("@FECHARES", FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Reservas_Exsico();
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

		public ObservableCollection<Reservas_Exsico> GetAllReservas_ExsicoEnterpriseCtta(string IDEMPRESA, string FECHARES)
		{
			try
			{
				ObservableCollection<Reservas_Exsico> items = new ObservableCollection<Reservas_Exsico>();
				Reservas_Exsico item = new Reservas_Exsico();
				Instance.DAAsignarProcedure("V4MVC_RESERVAS_EXSICO_SELECT_ENTERPRISE_CTTA");
				Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FECHARES", FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Reservas_Exsico();
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

		public ObservableCollection<Reservas_Exsico> GetAllTurnosExsicoCtta(string FECHARES)
		{
			try
			{
				ObservableCollection<Reservas_Exsico> items = new ObservableCollection<Reservas_Exsico>();
				Reservas_Exsico item = new Reservas_Exsico();
				Instance.DAAsignarProcedure("V4MVC_TURNOS_EXSICO_SELECT_CTTA");
				Instance.DAAgregarParametro("@FECHARES", FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Reservas_Exsico();
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

		#region [ Métodos ]

		public bool EliminarReservasExsicoCtta(string USUARIO, string LIST_ID)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_RESERVAS_EXSICO_DELETE_CTTA");
				Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@LIST_ID", LIST_ID, SqlDbType.NVarChar, 250, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{ return true; }
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

	}
}
