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
	public partial class DAFiniquitos : IDAFiniquitos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
        public LoaderEntity<Finiquitos> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAFiniquitos(IDataAccessEnterprise container)
		{
            this.Instance = container;
            Loader = new LoaderEntity<Finiquitos>();
			Finiquitos item = new Finiquitos();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Finiquitos> GetAll()
		{
			try
			{
				ObservableCollection<Finiquitos> items = new ObservableCollection<Finiquitos>();
				Finiquitos item = new Finiquitos();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Finiquitos();
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
		public Finiquitos GetOne(String Rut, String FechaCambio)
		{
			try
			{
				Finiquitos item = new Finiquitos();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@Rut", Rut, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FechaCambio", FechaCambio, SqlDbType.NVarChar, 8, ParameterDirection.Input);
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
		public bool Save(ref Finiquitos item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@Rut", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FechaCambio", item.FechaCambio, SqlDbType.NVarChar, 8, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@Rut", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FechaCambio", item.FechaCambio, SqlDbType.NVarChar, 8, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@Rut", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FechaCambio", item.FechaCambio, SqlDbType.NVarChar, 8, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@EmpOrigen", item.EmpOrigen, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EmpDest", item.EmpDest, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FechaMod", item.FechaMod, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HoraMod", item.HoraMod, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NroPase", item.NroPase, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@Finiquito", item.Finiquito, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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
