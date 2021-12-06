using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;
namespace V4mvc.DataAccess
{
	public partial class DAProgBus : IDAProgBus
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<ProgBus> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAProgBus(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<ProgBus>();
			ProgBus item = new ProgBus();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<ProgBus> GetAll()
		{
			try
			{
				ObservableCollection<ProgBus> items = new ObservableCollection<ProgBus>();
				ProgBus item = new ProgBus();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new ProgBus();
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
		public ProgBus GetOne(Decimal IDPROG)
		{
			try
			{
				ProgBus item = new ProgBus();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@IDPROG", IDPROG, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
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
		public bool Save(ref ProgBus item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDPROG", item.IDPROG, SqlDbType.Decimal, 18, 0, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@IDPROG", item.IDPROG, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDPROG", item.IDPROG, SqlDbType.Decimal, 18, 0, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@PATENTE", item.PATENTE, SqlDbType.NVarChar, 6, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ORIGEN", item.ORIGEN, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESTINO", item.DESTINO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DURACION", item.DURACION, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORA", item.HORA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@RECORRIDO", item.RECORRIDO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@IDFLOTA", item.IDFLOTA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIRECCION", item.DIRECCION, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
