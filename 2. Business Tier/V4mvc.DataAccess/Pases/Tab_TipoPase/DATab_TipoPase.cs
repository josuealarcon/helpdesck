using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DATab_TipoPase : IDATab_TipoPase
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Tab_TipoPase> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DATab_TipoPase(IDataAccessEnterprise container)
		{
			//Instance = container;
			Loader = new LoaderEntity<Tab_TipoPase>();
			Tab_TipoPase item = new Tab_TipoPase();
			Loader.EntityType = item.GetType();
            Instance = container;
        }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Tab_TipoPase> GetAll()
		{
			try
			{
				ObservableCollection<Tab_TipoPase> items = new ObservableCollection<Tab_TipoPase>();
				Tab_TipoPase item = new Tab_TipoPase();
				Instance.DAAsignarProcedure("TAB_ID_TSS");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Tab_TipoPase();
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
		public Tab_TipoPase GetOne(Int16 ID_TIPOPASE)
		{
			try
			{
				Tab_TipoPase item = new Tab_TipoPase();
				Instance.DAAsignarProcedure("TAB_ID_TSS");
				Instance.DAAgregarParametro("@ID_TIPOPASE", ID_TIPOPASE, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		public bool Save(ref Tab_TipoPase item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("TAB_SI_UnReg");
							Instance.DAAgregarParametro("@ID_TIPOPASE", item.ID_TIPOPASE, SqlDbType.SmallInt, 2, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("TAB_ID_TSU_UnReg");
							Instance.DAAgregarParametro("@ID_TIPOPASE", item.ID_TIPOPASE, SqlDbType.SmallInt, 2, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@ID_TIPOPASE", item.ID_TIPOPASE, SqlDbType.SmallInt, 2, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@TIPOPASE", item.TIPOPASE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DESC_TIPOPASE", item.DESC_TIPOPASE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@REQ_OST", item.REQ_OST, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@APRUEBA_MEDICO", item.APRUEBA_MEDICO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
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
