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
	public partial class DATab_Combustible : IDATab_Combustible
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<Tab_Combustible> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DATab_Combustible(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<Tab_Combustible>();
			Tab_Combustible item = new Tab_Combustible();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Tab_Combustible> GetAll()
		{
			try
			{
				ObservableCollection<Tab_Combustible> items = new ObservableCollection<Tab_Combustible>();
				Tab_Combustible item = new Tab_Combustible();
				Instance.DAAsignarProcedure("V4MVC_TAB_COMBUSTIBLE_SELECT");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Tab_Combustible();
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
		public Tab_Combustible GetOne(Int32 IDCOMBUSTIBLE)
		{
			try
			{
				Tab_Combustible item = new Tab_Combustible();
				Instance.DAAsignarProcedure("V4MVC_TAB_COMBUSTIBLE_SELECT");
				Instance.DAAgregarParametro("@IDCOMBUSTIBLE", IDCOMBUSTIBLE, SqlDbType.Int, 4, ParameterDirection.Input);
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
		public bool Save(ref Tab_Combustible item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDCOMBUSTIBLE", item.IDCOMBUSTIBLE, SqlDbType.Int, 4, ParameterDirection.InputOutput);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDCOMBUSTIBLE", item.IDCOMBUSTIBLE, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							Instance.DAAgregarParametro("@IDCOMBUSTIBLE", item.IDCOMBUSTIBLE, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@COMBUSTIBLE", item.COMBUSTIBLE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
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
