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
	public partial class DATab_Reservasico : IDATab_Reservasico
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Tab_Reservasico> Loader { get; set; }
		public IDataAccessEnterprise Instance { get; set; }
		#endregion

		#region [ Constructores ]
		public DATab_Reservasico(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Tab_Reservasico>();
			Tab_Reservasico item = new Tab_Reservasico();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Tab_Reservasico> GetAll()
		{
			try
			{
				ObservableCollection<Tab_Reservasico> items = new ObservableCollection<Tab_Reservasico>();
				Tab_Reservasico item = new Tab_Reservasico();
				Instance.DAAsignarProcedure("V4MVC_LIST_EXSICO_SELECT_CTTA");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Tab_Reservasico();
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
		public Tab_Reservasico GetOne(Decimal ID)
		{
			try
			{
				Tab_Reservasico item = new Tab_Reservasico();
				Instance.DAAsignarProcedure("_SS_UnReg");
				Instance.DAAgregarParametro("@ID", ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
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
		public bool Save(ref Tab_Reservasico item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@HORAINI", item.HORAINI, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAFIN", item.HORAFIN, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAINI_COL", item.HORAINI_COL, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAFIN_COL", item.HORAFIN_COL, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FUNCPORHORA", item.FUNCPORHORA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIEMPORESERVA", item.TIEMPORESERVA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIEMPORENUEVA", item.TIEMPORENUEVA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LUN", item.LUN, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MAR", item.MAR, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@MIE", item.MIE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@JUE", item.JUE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@VIE", item.VIE, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@SAB", item.SAB, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DOM", item.DOM, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TIEMPOCANCELA", item.TIEMPOCANCELA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHALIMITE", item.FECHALIMITE, SqlDbType.NVarChar, 8, ParameterDirection.Input);
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
