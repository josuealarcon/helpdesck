using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAServicio
    {

		#region [ Consultas ]

		public ObservableCollection<Servicio> GetAllServicioDivisionCtta(string DIVISION)
		{
			try
			{
				ObservableCollection<Servicio> items = new ObservableCollection<Servicio>();
				Servicio item = new Servicio();
				Instance.DAAsignarProcedure("V4MVC_SERVICIO_SELECT_DIVISION");
				Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
		public ObservableCollection<Servicio> GetListServiciosLocalesCasinoPermitidosAutorizaciones_Ctta()
		{
			try
			{
				ObservableCollection<Servicio> items = new ObservableCollection<Servicio>();
				Servicio item = new Servicio();
				Instance.DAAsignarProcedure("V4MVC_SERVICIO_SELECT_SERVICIO_LOCAL_CASINO_PERMITIDO_CTTA");
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

		#endregion

		#region [ Métodos ]

		#endregion

	}
}
